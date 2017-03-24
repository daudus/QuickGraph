Imports QuickGraph

Public Class Main

    Sub _init()
        Dim edges As New System.Collections.Generic.List(Of TaggedEdge(Of Integer, String))
        Dim edge As TaggedEdge(Of Integer, String)
        Dim graph As AdjacencyGraph(Of Integer, TaggedEdge(Of Integer, String))


        edge = New TaggedEdge(Of Integer, String)(1, 2, "hello")
        edges.Add(edge)
        edge = New TaggedEdge(Of Integer, String)(0, 1, "peace of cake")
        edges.Add(edge)
        graph = New AdjacencyGraph(Of Integer, TaggedEdge(Of Integer, String))

        For Each edge In edges
            If Not graph.AddVerticesAndEdge(edge) Then
                MsgBox("Issue with initialization of graph", MsgBoxStyle.ApplicationModal, "Warning")
            End If
        Next
        Dim s As New System.Text.StringBuilder()
        For Each v In graph.Vertices
            For Each e In graph.OutEdges(v)
                s.Append(e.ToString() & vbCrLf)
            Next e
        Next v
        MsgBox(s.ToString(), MsgBoxStyle.ApplicationModal, "There is that graph: ")
    End Sub

    Private Sub BtnCreateGraph_Click(sender As Object, e As EventArgs) Handles btnCreateGraph.Click
        _init()
    End Sub
End Class
