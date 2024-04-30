---
title: WorkitemQueryJobCreate
---
## ININ.PureCloudApi.Model.WorkitemQueryJobCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PageSize** | **int?** | The total page size requested. Default 25 | [optional] |
| **PageNumber** | **int?** | The page number requested | [optional] |
| **Filters** | [**List&lt;WorkitemQueryJobFilter&gt;**](WorkitemQueryJobFilter.html) | List of filter objects to be used in the search. | |
| **Expands** | **List&lt;string&gt;** | List of entity attributes to be expanded in the result. | [optional] |
| **Attributes** | **List&lt;string&gt;** | List of entity attributes to be retrieved in the result. | [optional] |
| **Sort** | [**WorkitemQueryJobSort**](WorkitemQueryJobSort.html) | Sort | [optional] |
{: class="table table-striped"}

