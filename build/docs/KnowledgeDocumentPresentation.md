---
title: KnowledgeDocumentPresentation
---
## ININ.PureCloudApi.Model.KnowledgeDocumentPresentation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Documents** | [**List&lt;KnowledgeDocumentVersionVariationReference&gt;**](KnowledgeDocumentVersionVariationReference.html) | The presented documents | |
| **SearchId** | **string** | The search that surfaced the documents that were presented. | [optional] |
| **QueryType** | **string** | The type of the query that surfaced the documents. | [optional] |
| **SurfacingMethod** | **string** | The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown. | [optional] |
| **SessionId** | **string** | Knowledge session ID. | [optional] |
| **ConversationContext** | [**KnowledgeConversationContext**](KnowledgeConversationContext.html) | Conversation context information if the documents were presented in the context of a conversation. | [optional] |
| **Application** | [**KnowledgeSearchClientApplication**](KnowledgeSearchClientApplication.html) | The client application in which the documents were presented. | |
{: class="table table-striped"}

