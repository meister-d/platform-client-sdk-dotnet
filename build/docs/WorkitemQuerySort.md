---
title: WorkitemQuerySort
---
## ININ.PureCloudApi.Model.WorkitemQuerySort

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Specify an attribute for sorting. It&#39;s possible to use an attribute both for sorting and in the query at the same time, but these restrictions apply: Only the operators EQ, LT, LTE, GT, GTE, BETWEEN and BEGINS_WITH are supported and the attribute can&#39;t be present in more than one filter. Sorting by priority is only supported in workbinId based queries. | [optional] |
| **Ascending** | **bool?** | Sort Ascending | [optional] |
{: class="table table-striped"}

