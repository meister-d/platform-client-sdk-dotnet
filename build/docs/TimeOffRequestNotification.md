---
title: TimeOffRequestNotification
---
## ININ.PureCloudApi.Model.TimeOffRequestNotification

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TimeOffRequestId** | **string** | The ID of this time off request | [optional] |
| **User** | [**UserReference**](UserReference.html) | The user associated with this time off request | [optional] |
| **IsFullDayRequest** | **bool?** | Whether this is a full day request (false means partial day) | [optional] |
| **Status** | **string** | The status of this time off request | [optional] |
| **PartialDayStartDateTimes** | **List&lt;DateTime?&gt;** | A set of start date-times in ISO-8601 format for partial day requests.  Will be not empty if isFullDayRequest == false | [optional] |
| **FullDayManagementUnitDates** | **List&lt;string&gt;** | A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.  Will be not empty if isFullDayRequest == true | [optional] |
{: class="table table-striped"}

