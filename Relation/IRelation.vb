Namespace OptimOrm


    ''' <summary>Representa una relaci�n</summary>
    Public Interface IRelation

        Function Fill() As Boolean
        Function SaveAll() As Boolean
        Function DeleteAll() As Boolean
        Function GetAll() As List(Of Model)
        Function GetUnique() As Model
        ''' <summary>Agrega un modelo relacionado, que ser� �nico (relaci�n varios-a-uno)</summary>
        Sub AddUnique(ByVal m As Model)
        ''' <summary>Agrega un modelo relacionado (relaci�n uno-a-varios)</summary>
        Sub AddAsForeign(ByVal m As Model)
        Sub dump(ByVal nestingLevel As Integer, ByVal w As System.IO.TextWriter)

    End Interface


End Namespace