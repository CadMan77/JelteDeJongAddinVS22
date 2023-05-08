Imports Autodesk.iLogic.Interfaces
Imports Autodesk.iLogic.Runtime
Imports Inventor

Public MustInherit Class AbstractRule

    Public Property ThisApplication As Inventor.Application

    Public ReadOnly Property ThisDoc As ICadDoc
        'Public ReadOnly Property ThisDoc As Inventor.Document
        Get
            Return New CadDoc(ThisApplication.ActiveDocument)
            'Return ThisApplication.ActiveDocument
        End Get
    End Property

End Class
