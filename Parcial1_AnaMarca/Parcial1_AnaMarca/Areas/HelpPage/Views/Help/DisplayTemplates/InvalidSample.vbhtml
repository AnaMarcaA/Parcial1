@Imports Parcial1_AnaMarca.Areas.HelpPage
@ModelType InvalidSample

@If HttpContext.Current.IsDebuggingEnabled Then
    @<div class="warning-message-container">
        <p>@Model.ErrorMessage</p>
    </div>
Else
    @<p>Sample not available.</p>
End If