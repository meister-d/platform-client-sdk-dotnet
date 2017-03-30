---
title: TelephonyProvidersEdgeApi
---
## PureCloudPlatform.Client.V2.Api.TelephonyProvidersEdgeApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteTelephonyProvidersEdge**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedge) | **DELETE** /api/v2/telephony/providers/edges/{edgeId} | Delete a edge. |
| [**DeleteTelephonyProvidersEdgeLogicalinterface**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgelogicalinterface) | **DELETE** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces/{interfaceId} | Delete an edge logical interface |
| [**DeleteTelephonyProvidersEdgeSoftwareupdate**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgesoftwareupdate) | **DELETE** /api/v2/telephony/providers/edges/{edgeId}/softwareupdate | Cancels any in-progress update for this edge. |
| [**DeleteTelephonyProvidersEdgesCertificateauthority**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgescertificateauthority) | **DELETE** /api/v2/telephony/providers/edges/certificateauthorities/{certificateId} | Delete a certificate authority. |
| [**DeleteTelephonyProvidersEdgesDidpool**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgesdidpool) | **DELETE** /api/v2/telephony/providers/edges/didpools/{didPoolId} | Delete a DID Pool by ID. |
| [**DeleteTelephonyProvidersEdgesEdgegroup**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgesedgegroup) | **DELETE** /api/v2/telephony/providers/edges/edgegroups/{edgeGroupId} | Delete an edge group. |
| [**DeleteTelephonyProvidersEdgesEndpoint**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgesendpoint) | **DELETE** /api/v2/telephony/providers/edges/endpoints/{endpointId} | Delete endpoint |
| [**DeleteTelephonyProvidersEdgesExtensionpool**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgesextensionpool) | **DELETE** /api/v2/telephony/providers/edges/extensionpools/{extensionPoolId} | Delete an extension pool by ID |
| [**DeleteTelephonyProvidersEdgesOutboundroute**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgesoutboundroute) | **DELETE** /api/v2/telephony/providers/edges/outboundroutes/{outboundRouteId} | Delete Outbound Route |
| [**DeleteTelephonyProvidersEdgesPhone**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgesphone) | **DELETE** /api/v2/telephony/providers/edges/phones/{phoneId} | Delete a Phone by ID |
| [**DeleteTelephonyProvidersEdgesPhonebasesetting**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgesphonebasesetting) | **DELETE** /api/v2/telephony/providers/edges/phonebasesettings/{phoneBaseId} | Delete a Phone Base Settings by ID |
| [**DeleteTelephonyProvidersEdgesSite**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgessite) | **DELETE** /api/v2/telephony/providers/edges/sites/{siteId} | Delete a Site by ID |
| [**DeleteTelephonyProvidersEdgesSiteOutboundroute**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgessiteoutboundroute) | **DELETE** /api/v2/telephony/providers/edges/sites/{siteId}/outboundroutes/{outboundRouteId} | Delete Outbound Route |
| [**DeleteTelephonyProvidersEdgesTrunkbasesetting**](TelephonyProvidersEdgeApi.html#deletetelephonyprovidersedgestrunkbasesetting) | **DELETE** /api/v2/telephony/providers/edges/trunkbasesettings/{trunkBaseSettingsId} | Delete a Trunk Base Settings object by ID |
| [**GetConfigurationSchemasEdgesVnext**](TelephonyProvidersEdgeApi.html#getconfigurationschemasedgesvnext) | **GET** /api/v2/configuration/schemas/edges/vnext | Lists available schema categories (Deprecated) |
| [**GetConfigurationSchemasEdgesVnextSchemaCategory**](TelephonyProvidersEdgeApi.html#getconfigurationschemasedgesvnextschemacategory) | **GET** /api/v2/configuration/schemas/edges/vnext/{schemaCategory} | List schemas of a specific category (Deprecated) |
| [**GetConfigurationSchemasEdgesVnextSchemaCategorySchemaType**](TelephonyProvidersEdgeApi.html#getconfigurationschemasedgesvnextschemacategoryschematype) | **GET** /api/v2/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType} | List schemas of a specific category (Deprecated) |
| [**GetConfigurationSchemasEdgesVnextSchemaCategorySchemaTypeSchemaId**](TelephonyProvidersEdgeApi.html#getconfigurationschemasedgesvnextschemacategoryschematypeschemaid) | **GET** /api/v2/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId} | Get a json schema (Deprecated) |
| [**GetConfigurationSchemasEdgesVnextSchemaCategorySchemaTypeSchemaIdExtensionTypeMetadataId**](TelephonyProvidersEdgeApi.html#getconfigurationschemasedgesvnextschemacategoryschematypeschemaidextensiontypemetadataid) | **GET** /api/v2/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}/{extensionType}/{metadataId} | Get metadata for a schema (Deprecated) |
| [**GetTelephonyProvidersEdge**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedge) | **GET** /api/v2/telephony/providers/edges/{edgeId} | Get edge. |
| [**GetTelephonyProvidersEdgeLine**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgeline) | **GET** /api/v2/telephony/providers/edges/{edgeId}/lines/{lineId} | Get line |
| [**GetTelephonyProvidersEdgeLines**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgelines) | **GET** /api/v2/telephony/providers/edges/{edgeId}/lines | Get the list of lines. |
| [**GetTelephonyProvidersEdgeLogicalinterface**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgelogicalinterface) | **GET** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces/{interfaceId} | Get an edge logical interface |
| [**GetTelephonyProvidersEdgeLogicalinterfaces**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgelogicalinterfaces) | **GET** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces | Get edge logical interfaces. |
| [**GetTelephonyProvidersEdgeLogsJob**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgelogsjob) | **GET** /api/v2/telephony/providers/edges/{edgeId}/logs/jobs/{jobId} | Get an Edge logs job. |
| [**GetTelephonyProvidersEdgePhysicalinterface**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgephysicalinterface) | **GET** /api/v2/telephony/providers/edges/{edgeId}/physicalinterfaces/{interfaceId} | Get edge physical interface. |
| [**GetTelephonyProvidersEdgePhysicalinterfaces**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgephysicalinterfaces) | **GET** /api/v2/telephony/providers/edges/{edgeId}/physicalinterfaces | Retrieve a list of all configured physical interfaces from a specific edge. |
| [**GetTelephonyProvidersEdgeSetuppackage**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesetuppackage) | **GET** /api/v2/telephony/providers/edges/{edgeId}/setuppackage | Get the setup package for a locally deployed edge device. This is needed to complete the setup process for the virtual edge. |
| [**GetTelephonyProvidersEdgeSoftwareupdate**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesoftwareupdate) | **GET** /api/v2/telephony/providers/edges/{edgeId}/softwareupdate | Gets software update status information about any edge. |
| [**GetTelephonyProvidersEdgeSoftwareversions**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesoftwareversions) | **GET** /api/v2/telephony/providers/edges/{edgeId}/softwareversions | Gets all the available software versions for this edge. |
| [**GetTelephonyProvidersEdges**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedges) | **GET** /api/v2/telephony/providers/edges | Get the list of edges. |
| [**GetTelephonyProvidersEdgesAvailablelanguages**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesavailablelanguages) | **GET** /api/v2/telephony/providers/edges/availablelanguages | Get the list of available languages. |
| [**GetTelephonyProvidersEdgesCertificateauthorities**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgescertificateauthorities) | **GET** /api/v2/telephony/providers/edges/certificateauthorities | Get the list of certificate authorities. |
| [**GetTelephonyProvidersEdgesCertificateauthority**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgescertificateauthority) | **GET** /api/v2/telephony/providers/edges/certificateauthorities/{certificateId} | Get a certificate authority. |
| [**GetTelephonyProvidersEdgesDid**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesdid) | **GET** /api/v2/telephony/providers/edges/dids/{didId} | Get a DID by ID. |
| [**GetTelephonyProvidersEdgesDidpool**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesdidpool) | **GET** /api/v2/telephony/providers/edges/didpools/{didPoolId} | Get a DID Pool by ID. |
| [**GetTelephonyProvidersEdgesDidpools**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesdidpools) | **GET** /api/v2/telephony/providers/edges/didpools | Get a listing of DID Pools |
| [**GetTelephonyProvidersEdgesDids**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesdids) | **GET** /api/v2/telephony/providers/edges/dids | Get a listing of DIDs |
| [**GetTelephonyProvidersEdgesEdgegroup**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesedgegroup) | **GET** /api/v2/telephony/providers/edges/edgegroups/{edgeGroupId} | Get edge group. |
| [**GetTelephonyProvidersEdgesEdgegroupEdgetrunkbasis**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesedgegroupedgetrunkbasis) | **GET** /api/v2/telephony/providers/edges/edgegroups/{edgegroupId}/edgetrunkbases/{edgetrunkbaseId} | Gets the edge trunk base associated with the edge group |
| [**GetTelephonyProvidersEdgesEdgegroups**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesedgegroups) | **GET** /api/v2/telephony/providers/edges/edgegroups | Get the list of edge groups. |
| [**GetTelephonyProvidersEdgesEdgeversionreport**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesedgeversionreport) | **GET** /api/v2/telephony/providers/edges/edgeversionreport | Get the edge version report. |
| [**GetTelephonyProvidersEdgesEndpoint**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesendpoint) | **GET** /api/v2/telephony/providers/edges/endpoints/{endpointId} | Get endpoint |
| [**GetTelephonyProvidersEdgesEndpoints**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesendpoints) | **GET** /api/v2/telephony/providers/edges/endpoints | Get endpoints |
| [**GetTelephonyProvidersEdgesExtension**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesextension) | **GET** /api/v2/telephony/providers/edges/extensions/{extensionId} | Get an extension by ID. |
| [**GetTelephonyProvidersEdgesExtensionpool**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesextensionpool) | **GET** /api/v2/telephony/providers/edges/extensionpools/{extensionPoolId} | Get an extension pool by ID |
| [**GetTelephonyProvidersEdgesExtensionpools**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesextensionpools) | **GET** /api/v2/telephony/providers/edges/extensionpools | Get a listing of extension pools |
| [**GetTelephonyProvidersEdgesExtensions**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesextensions) | **GET** /api/v2/telephony/providers/edges/extensions | Get a listing of extensions |
| [**GetTelephonyProvidersEdgesLine**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesline) | **GET** /api/v2/telephony/providers/edges/lines/{lineId} | Get a Line by ID |
| [**GetTelephonyProvidersEdgesLinebasesetting**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgeslinebasesetting) | **GET** /api/v2/telephony/providers/edges/linebasesettings/{lineBaseId} | Get a line base settings object by ID |
| [**GetTelephonyProvidersEdgesLinebasesettings**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgeslinebasesettings) | **GET** /api/v2/telephony/providers/edges/linebasesettings | Get a listing of line base settings objects |
| [**GetTelephonyProvidersEdgesLines**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgeslines) | **GET** /api/v2/telephony/providers/edges/lines | Get a list of Lines |
| [**GetTelephonyProvidersEdgesLinesTemplate**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgeslinestemplate) | **GET** /api/v2/telephony/providers/edges/lines/template | Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance |
| [**GetTelephonyProvidersEdgesLogicalinterfaces**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgeslogicalinterfaces) | **GET** /api/v2/telephony/providers/edges/logicalinterfaces | Get edge logical interfaces. |
| [**GetTelephonyProvidersEdgesOutboundroute**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesoutboundroute) | **GET** /api/v2/telephony/providers/edges/outboundroutes/{outboundRouteId} | Get outbound route |
| [**GetTelephonyProvidersEdgesOutboundroutes**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesoutboundroutes) | **GET** /api/v2/telephony/providers/edges/outboundroutes | Get outbound routes |
| [**GetTelephonyProvidersEdgesPhone**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesphone) | **GET** /api/v2/telephony/providers/edges/phones/{phoneId} | Get a Phone by ID |
| [**GetTelephonyProvidersEdgesPhonebasesetting**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesphonebasesetting) | **GET** /api/v2/telephony/providers/edges/phonebasesettings/{phoneBaseId} | Get a Phone Base Settings object by ID |
| [**GetTelephonyProvidersEdgesPhonebasesettings**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesphonebasesettings) | **GET** /api/v2/telephony/providers/edges/phonebasesettings | Get a list of Phone Base Settings objects |
| [**GetTelephonyProvidersEdgesPhonebasesettingsAvailablemetabases**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesphonebasesettingsavailablemetabases) | **GET** /api/v2/telephony/providers/edges/phonebasesettings/availablemetabases | Get a list of available makes and models to create a new Phone Base Settings |
| [**GetTelephonyProvidersEdgesPhonebasesettingsTemplate**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesphonebasesettingstemplate) | **GET** /api/v2/telephony/providers/edges/phonebasesettings/template | Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance |
| [**GetTelephonyProvidersEdgesPhones**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesphones) | **GET** /api/v2/telephony/providers/edges/phones | Get a list of Phone Instances |
| [**GetTelephonyProvidersEdgesPhonesTemplate**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgesphonestemplate) | **GET** /api/v2/telephony/providers/edges/phones/template | Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance |
| [**GetTelephonyProvidersEdgesSite**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgessite) | **GET** /api/v2/telephony/providers/edges/sites/{siteId} | Get a Site by ID. |
| [**GetTelephonyProvidersEdgesSiteNumberplan**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgessitenumberplan) | **GET** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans/{numberPlanId} | Get a Number Plan by ID. |
| [**GetTelephonyProvidersEdgesSiteNumberplans**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgessitenumberplans) | **GET** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans | Get the list of Number Plans for this Site. |
| [**GetTelephonyProvidersEdgesSiteNumberplansClassifications**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgessitenumberplansclassifications) | **GET** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans/classifications | Get a list of Classifications for this Site |
| [**GetTelephonyProvidersEdgesSiteOutboundroute**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgessiteoutboundroute) | **GET** /api/v2/telephony/providers/edges/sites/{siteId}/outboundroutes/{outboundRouteId} | Get an outbound route |
| [**GetTelephonyProvidersEdgesSiteOutboundroutes**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgessiteoutboundroutes) | **GET** /api/v2/telephony/providers/edges/sites/{siteId}/outboundroutes | Get outbound routes |
| [**GetTelephonyProvidersEdgesSites**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgessites) | **GET** /api/v2/telephony/providers/edges/sites | Get the list of Sites. |
| [**GetTelephonyProvidersEdgesTimezones**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgestimezones) | **GET** /api/v2/telephony/providers/edges/timezones | Get a list of Edge-compatible time zones |
| [**GetTelephonyProvidersEdgesTrunk**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgestrunk) | **GET** /api/v2/telephony/providers/edges/trunks/{trunkId} | Get a Trunk by ID |
| [**GetTelephonyProvidersEdgesTrunkbasesetting**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgestrunkbasesetting) | **GET** /api/v2/telephony/providers/edges/trunkbasesettings/{trunkBaseSettingsId} | Get a Trunk Base Settings object by ID |
| [**GetTelephonyProvidersEdgesTrunkbasesettings**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgestrunkbasesettings) | **GET** /api/v2/telephony/providers/edges/trunkbasesettings | Get Trunk Base Settings listing |
| [**GetTelephonyProvidersEdgesTrunkbasesettingsAvailablemetabases**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgestrunkbasesettingsavailablemetabases) | **GET** /api/v2/telephony/providers/edges/trunkbasesettings/availablemetabases | Get a list of available makes and models to create a new Trunk Base Settings |
| [**GetTelephonyProvidersEdgesTrunkbasesettingsTemplate**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgestrunkbasesettingstemplate) | **GET** /api/v2/telephony/providers/edges/trunkbasesettings/template | Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance |
| [**GetTelephonyProvidersEdgesTrunks**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgestrunks) | **GET** /api/v2/telephony/providers/edges/trunks | Get the list of available trunks. |
| [**GetTelephonyProvidersEdgesTrunkswithrecording**](TelephonyProvidersEdgeApi.html#gettelephonyprovidersedgestrunkswithrecording) | **GET** /api/v2/telephony/providers/edges/trunkswithrecording | Get Counts of trunks that have recording disabled or enabled |
| [**PostTelephonyProvidersEdgeLogicalinterfaces**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgelogicalinterfaces) | **POST** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces | Create an edge logical interface. |
| [**PostTelephonyProvidersEdgeLogsJobUpload**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgelogsjobupload) | **POST** /api/v2/telephony/providers/edges/{edgeId}/logs/jobs/{jobId}/upload | Request that the specified fileIds be uploaded from the Edge. |
| [**PostTelephonyProvidersEdgeLogsJobs**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgelogsjobs) | **POST** /api/v2/telephony/providers/edges/{edgeId}/logs/jobs | Create a job to upload a list of Edge logs. |
| [**PostTelephonyProvidersEdgeReboot**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgereboot) | **POST** /api/v2/telephony/providers/edges/{edgeId}/reboot | Reboot an Edge |
| [**PostTelephonyProvidersEdgeSoftwareupdate**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgesoftwareupdate) | **POST** /api/v2/telephony/providers/edges/{edgeId}/softwareupdate | Starts a software update for this edge. |
| [**PostTelephonyProvidersEdgeStatuscode**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgestatuscode) | **POST** /api/v2/telephony/providers/edges/{edgeId}/statuscode | Take an Edge in or out of service |
| [**PostTelephonyProvidersEdgeUnpair**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgeunpair) | **POST** /api/v2/telephony/providers/edges/{edgeId}/unpair | Unpair an Edge |
| [**PostTelephonyProvidersEdges**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedges) | **POST** /api/v2/telephony/providers/edges | Create an edge. |
| [**PostTelephonyProvidersEdgesAddressvalidation**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgesaddressvalidation) | **POST** /api/v2/telephony/providers/edges/addressvalidation | Validates a street address |
| [**PostTelephonyProvidersEdgesCertificateauthorities**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgescertificateauthorities) | **POST** /api/v2/telephony/providers/edges/certificateauthorities | Create a certificate authority. |
| [**PostTelephonyProvidersEdgesDidpools**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgesdidpools) | **POST** /api/v2/telephony/providers/edges/didpools | Create a new DID pool |
| [**PostTelephonyProvidersEdgesEdgegroups**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgesedgegroups) | **POST** /api/v2/telephony/providers/edges/edgegroups | Create an edge group. |
| [**PostTelephonyProvidersEdgesEndpoints**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgesendpoints) | **POST** /api/v2/telephony/providers/edges/endpoints | Create endpoint |
| [**PostTelephonyProvidersEdgesExtensionpools**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgesextensionpools) | **POST** /api/v2/telephony/providers/edges/extensionpools | Create a new extension pool |
| [**PostTelephonyProvidersEdgesOutboundroutes**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgesoutboundroutes) | **POST** /api/v2/telephony/providers/edges/outboundroutes | Create outbound rule |
| [**PostTelephonyProvidersEdgesPhoneReboot**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgesphonereboot) | **POST** /api/v2/telephony/providers/edges/phones/{phoneId}/reboot | Reboot a Phone |
| [**PostTelephonyProvidersEdgesPhonebasesettings**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgesphonebasesettings) | **POST** /api/v2/telephony/providers/edges/phonebasesettings | Create a new Phone Base Settings object |
| [**PostTelephonyProvidersEdgesPhones**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgesphones) | **POST** /api/v2/telephony/providers/edges/phones | Create a new Phone |
| [**PostTelephonyProvidersEdgesPhonesReboot**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgesphonesreboot) | **POST** /api/v2/telephony/providers/edges/phones/reboot | Reboot Multiple Phones |
| [**PostTelephonyProvidersEdgesSiteOutboundroutes**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgessiteoutboundroutes) | **POST** /api/v2/telephony/providers/edges/sites/{siteId}/outboundroutes | Create outbound route |
| [**PostTelephonyProvidersEdgesSiteRebalance**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgessiterebalance) | **POST** /api/v2/telephony/providers/edges/sites/{siteId}/rebalance | Triggers the rebalance operation. |
| [**PostTelephonyProvidersEdgesSites**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgessites) | **POST** /api/v2/telephony/providers/edges/sites | Create a Site. |
| [**PostTelephonyProvidersEdgesTrunkbasesettings**](TelephonyProvidersEdgeApi.html#posttelephonyprovidersedgestrunkbasesettings) | **POST** /api/v2/telephony/providers/edges/trunkbasesettings | Create a Trunk Base Settings object |
| [**PutTelephonyProvidersEdge**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedge) | **PUT** /api/v2/telephony/providers/edges/{edgeId} | Update a edge. |
| [**PutTelephonyProvidersEdgeLine**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgeline) | **PUT** /api/v2/telephony/providers/edges/{edgeId}/lines/{lineId} | Update a line. |
| [**PutTelephonyProvidersEdgeLogicalinterface**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgelogicalinterface) | **PUT** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces/{interfaceId} | Update an edge logical interface. |
| [**PutTelephonyProvidersEdgesCertificateauthority**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgescertificateauthority) | **PUT** /api/v2/telephony/providers/edges/certificateauthorities/{certificateId} | Update a certificate authority. |
| [**PutTelephonyProvidersEdgesDid**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgesdid) | **PUT** /api/v2/telephony/providers/edges/dids/{didId} | Update a DID by ID. |
| [**PutTelephonyProvidersEdgesDidpool**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgesdidpool) | **PUT** /api/v2/telephony/providers/edges/didpools/{didPoolId} | Update a DID Pool by ID. |
| [**PutTelephonyProvidersEdgesEdgegroup**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgesedgegroup) | **PUT** /api/v2/telephony/providers/edges/edgegroups/{edgeGroupId} | Update an edge group. |
| [**PutTelephonyProvidersEdgesEdgegroupEdgetrunkbasis**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgesedgegroupedgetrunkbasis) | **PUT** /api/v2/telephony/providers/edges/edgegroups/{edgegroupId}/edgetrunkbases/{edgetrunkbaseId} | Update the edge trunk base associated with the edge group |
| [**PutTelephonyProvidersEdgesEndpoint**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgesendpoint) | **PUT** /api/v2/telephony/providers/edges/endpoints/{endpointId} | Update endpoint |
| [**PutTelephonyProvidersEdgesExtension**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgesextension) | **PUT** /api/v2/telephony/providers/edges/extensions/{extensionId} | Update an extension by ID. |
| [**PutTelephonyProvidersEdgesExtensionpool**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgesextensionpool) | **PUT** /api/v2/telephony/providers/edges/extensionpools/{extensionPoolId} | Update an extension pool by ID |
| [**PutTelephonyProvidersEdgesOutboundroute**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgesoutboundroute) | **PUT** /api/v2/telephony/providers/edges/outboundroutes/{outboundRouteId} | Update outbound route |
| [**PutTelephonyProvidersEdgesPhone**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgesphone) | **PUT** /api/v2/telephony/providers/edges/phones/{phoneId} | Update a Phone by ID |
| [**PutTelephonyProvidersEdgesPhonebasesetting**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgesphonebasesetting) | **PUT** /api/v2/telephony/providers/edges/phonebasesettings/{phoneBaseId} | Update a Phone Base Settings by ID |
| [**PutTelephonyProvidersEdgesSite**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgessite) | **PUT** /api/v2/telephony/providers/edges/sites/{siteId} | Update a Site by ID. |
| [**PutTelephonyProvidersEdgesSiteNumberplans**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgessitenumberplans) | **PUT** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans | Update the list of Number Plans. |
| [**PutTelephonyProvidersEdgesSiteOutboundroute**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgessiteoutboundroute) | **PUT** /api/v2/telephony/providers/edges/sites/{siteId}/outboundroutes/{outboundRouteId} | Update outbound route |
| [**PutTelephonyProvidersEdgesTrunkbasesetting**](TelephonyProvidersEdgeApi.html#puttelephonyprovidersedgestrunkbasesetting) | **PUT** /api/v2/telephony/providers/edges/trunkbasesettings/{trunkBaseSettingsId} | Update a Trunk Base Settings object by ID |
{: class="table table-striped"}

<a name="deletetelephonyprovidersedge"></a>

## **string** DeleteTelephonyProvidersEdge (string edgeId)

Delete a edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Delete a edge.
                string result = apiInstance.DeleteTelephonyProvidersEdge(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdge: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletetelephonyprovidersedgelogicalinterface"></a>

## void DeleteTelephonyProvidersEdgeLogicalinterface (string edgeId, string interfaceId)

Delete an edge logical interface



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgeLogicalinterfaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID

            try
            {
                // Delete an edge logical interface
                apiInstance.DeleteTelephonyProvidersEdgeLogicalinterface(edgeId, interfaceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgeLogicalinterface: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletetelephonyprovidersedgesoftwareupdate"></a>

## **string** DeleteTelephonyProvidersEdgeSoftwareupdate (string edgeId)

Cancels any in-progress update for this edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgeSoftwareupdateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Cancels any in-progress update for this edge.
                string result = apiInstance.DeleteTelephonyProvidersEdgeSoftwareupdate(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgeSoftwareupdate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletetelephonyprovidersedgescertificateauthority"></a>

## **string** DeleteTelephonyProvidersEdgesCertificateauthority (string certificateId)

Delete a certificate authority.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesCertificateauthorityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var certificateId = certificateId_example;  // string | Certificate ID

            try
            {
                // Delete a certificate authority.
                string result = apiInstance.DeleteTelephonyProvidersEdgesCertificateauthority(certificateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesCertificateauthority: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletetelephonyprovidersedgesdidpool"></a>

## **string** DeleteTelephonyProvidersEdgesDidpool (string didPoolId)

Delete a DID Pool by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesDidpoolExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID

            try
            {
                // Delete a DID Pool by ID.
                string result = apiInstance.DeleteTelephonyProvidersEdgesDidpool(didPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesDidpool: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletetelephonyprovidersedgesedgegroup"></a>

## **string** DeleteTelephonyProvidersEdgesEdgegroup (string edgeGroupId)

Delete an edge group.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesEdgegroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID

            try
            {
                // Delete an edge group.
                string result = apiInstance.DeleteTelephonyProvidersEdgesEdgegroup(edgeGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesEdgegroup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletetelephonyprovidersedgesendpoint"></a>

## **string** DeleteTelephonyProvidersEdgesEndpoint (string endpointId)

Delete endpoint



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesEndpointExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var endpointId = endpointId_example;  // string | Endpoint ID

            try
            {
                // Delete endpoint
                string result = apiInstance.DeleteTelephonyProvidersEdgesEndpoint(endpointId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesEndpoint: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **endpointId** | **string**| Endpoint ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletetelephonyprovidersedgesextensionpool"></a>

## **string** DeleteTelephonyProvidersEdgesExtensionpool (string extensionPoolId)

Delete an extension pool by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesExtensionpoolExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID

            try
            {
                // Delete an extension pool by ID
                string result = apiInstance.DeleteTelephonyProvidersEdgesExtensionpool(extensionPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesExtensionpool: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletetelephonyprovidersedgesoutboundroute"></a>

## **string** DeleteTelephonyProvidersEdgesOutboundroute (string outboundRouteId)

Delete Outbound Route



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesOutboundrouteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID

            try
            {
                // Delete Outbound Route
                string result = apiInstance.DeleteTelephonyProvidersEdgesOutboundroute(outboundRouteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesOutboundroute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outboundRouteId** | **string**| Outbound route ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletetelephonyprovidersedgesphone"></a>

## **string** DeleteTelephonyProvidersEdgesPhone (string phoneId)

Delete a Phone by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesPhoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone ID

            try
            {
                // Delete a Phone by ID
                string result = apiInstance.DeleteTelephonyProvidersEdgesPhone(phoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesPhone: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletetelephonyprovidersedgesphonebasesetting"></a>

## **string** DeleteTelephonyProvidersEdgesPhonebasesetting (string phoneBaseId)

Delete a Phone Base Settings by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesPhonebasesettingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseId = phoneBaseId_example;  // string | Phone base ID

            try
            {
                // Delete a Phone Base Settings by ID
                string result = apiInstance.DeleteTelephonyProvidersEdgesPhonebasesetting(phoneBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesPhonebasesetting: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletetelephonyprovidersedgessite"></a>

## **string** DeleteTelephonyProvidersEdgesSite (string siteId)

Delete a Site by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesSiteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Delete a Site by ID
                string result = apiInstance.DeleteTelephonyProvidersEdgesSite(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesSite: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletetelephonyprovidersedgessiteoutboundroute"></a>

## **string** DeleteTelephonyProvidersEdgesSiteOutboundroute (string siteId, string outboundRouteId)

Delete Outbound Route



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesSiteOutboundrouteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID

            try
            {
                // Delete Outbound Route
                string result = apiInstance.DeleteTelephonyProvidersEdgesSiteOutboundroute(siteId, outboundRouteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesSiteOutboundroute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **outboundRouteId** | **string**| Outbound route ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletetelephonyprovidersedgestrunkbasesetting"></a>

## **string** DeleteTelephonyProvidersEdgesTrunkbasesetting (string trunkBaseSettingsId)

Delete a Trunk Base Settings object by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesTrunkbasesettingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkBaseSettingsId = trunkBaseSettingsId_example;  // string | Trunk Base ID

            try
            {
                // Delete a Trunk Base Settings object by ID
                string result = apiInstance.DeleteTelephonyProvidersEdgesTrunkbasesetting(trunkBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesTrunkbasesetting: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="getconfigurationschemasedgesvnext"></a>

## [**SchemaCategoryEntityListing**](SchemaCategoryEntityListing.html) GetConfigurationSchemasEdgesVnext (int? pageSize = null, int? pageNumber = null)

Lists available schema categories (Deprecated)



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConfigurationSchemasEdgesVnextExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Lists available schema categories (Deprecated)
                SchemaCategoryEntityListing result = apiInstance.GetConfigurationSchemasEdgesVnext(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetConfigurationSchemasEdgesVnext: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**SchemaCategoryEntityListing**](SchemaCategoryEntityListing.html)

<a name="getconfigurationschemasedgesvnextschemacategory"></a>

## [**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.html) GetConfigurationSchemasEdgesVnextSchemaCategory (string schemaCategory, int? pageSize = null, int? pageNumber = null)

List schemas of a specific category (Deprecated)



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConfigurationSchemasEdgesVnextSchemaCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // List schemas of a specific category (Deprecated)
                SchemaReferenceEntityListing result = apiInstance.GetConfigurationSchemasEdgesVnextSchemaCategory(schemaCategory, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetConfigurationSchemasEdgesVnextSchemaCategory: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaCategory** | **string**| Schema category |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.html)

<a name="getconfigurationschemasedgesvnextschemacategoryschematype"></a>

## [**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.html) GetConfigurationSchemasEdgesVnextSchemaCategorySchemaType (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)

List schemas of a specific category (Deprecated)



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConfigurationSchemasEdgesVnextSchemaCategorySchemaTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var schemaType = schemaType_example;  // string | Schema type
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // List schemas of a specific category (Deprecated)
                SchemaReferenceEntityListing result = apiInstance.GetConfigurationSchemasEdgesVnextSchemaCategorySchemaType(schemaCategory, schemaType, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetConfigurationSchemasEdgesVnextSchemaCategorySchemaType: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaCategory** | **string**| Schema category |  |
| **schemaType** | **string**| Schema type |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.html)

<a name="getconfigurationschemasedgesvnextschemacategoryschematypeschemaid"></a>

## [**Organization**](Organization.html) GetConfigurationSchemasEdgesVnextSchemaCategorySchemaTypeSchemaId (string schemaCategory, string schemaType, string schemaId)

Get a json schema (Deprecated)



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConfigurationSchemasEdgesVnextSchemaCategorySchemaTypeSchemaIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var schemaType = schemaType_example;  // string | Schema type
            var schemaId = schemaId_example;  // string | Schema ID

            try
            {
                // Get a json schema (Deprecated)
                Organization result = apiInstance.GetConfigurationSchemasEdgesVnextSchemaCategorySchemaTypeSchemaId(schemaCategory, schemaType, schemaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetConfigurationSchemasEdgesVnextSchemaCategorySchemaTypeSchemaId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaCategory** | **string**| Schema category |  |
| **schemaType** | **string**| Schema type |  |
| **schemaId** | **string**| Schema ID |  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.html)

<a name="getconfigurationschemasedgesvnextschemacategoryschematypeschemaidextensiontypemetadataid"></a>

## [**Organization**](Organization.html) GetConfigurationSchemasEdgesVnextSchemaCategorySchemaTypeSchemaIdExtensionTypeMetadataId (string schemaCategory, string schemaType, string schemaId, string extensionType, string metadataId, string type = null)

Get metadata for a schema (Deprecated)



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConfigurationSchemasEdgesVnextSchemaCategorySchemaTypeSchemaIdExtensionTypeMetadataIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var schemaType = schemaType_example;  // string | Schema type
            var schemaId = schemaId_example;  // string | Schema ID
            var extensionType = extensionType_example;  // string | extension
            var metadataId = metadataId_example;  // string | Metadata ID
            var type = type_example;  // string | Type (optional) 

            try
            {
                // Get metadata for a schema (Deprecated)
                Organization result = apiInstance.GetConfigurationSchemasEdgesVnextSchemaCategorySchemaTypeSchemaIdExtensionTypeMetadataId(schemaCategory, schemaType, schemaId, extensionType, metadataId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetConfigurationSchemasEdgesVnextSchemaCategorySchemaTypeSchemaIdExtensionTypeMetadataId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaCategory** | **string**| Schema category |  |
| **schemaType** | **string**| Schema type |  |
| **schemaId** | **string**| Schema ID |  |
| **extensionType** | **string**| extension |  |
| **metadataId** | **string**| Metadata ID |  |
| **type** | **string**| Type | [optional]  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.html)

<a name="gettelephonyprovidersedge"></a>

## [**Edge**](Edge.html) GetTelephonyProvidersEdge (string edgeId, List<string> expand = null)

Get edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 

            try
            {
                // Get edge.
                Edge result = apiInstance.GetTelephonyProvidersEdge(edgeId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdge: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **expand** | [**List<string>**](string.html)| Fields to expand in the response, comma-separated | [optional]  |
{: class="table table-striped"}

### Return type

[**Edge**](Edge.html)

<a name="gettelephonyprovidersedgeline"></a>

## [**EdgeLine**](EdgeLine.html) GetTelephonyProvidersEdgeLine (string edgeId, string lineId)

Get line



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeLineExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var lineId = lineId_example;  // string | Line ID

            try
            {
                // Get line
                EdgeLine result = apiInstance.GetTelephonyProvidersEdgeLine(edgeId, lineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeLine: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **lineId** | **string**| Line ID |  |
{: class="table table-striped"}

### Return type

[**EdgeLine**](EdgeLine.html)

<a name="gettelephonyprovidersedgelines"></a>

## [**EdgeLineEntityListing**](EdgeLineEntityListing.html) GetTelephonyProvidersEdgeLines (string edgeId, int? pageSize = null, int? pageNumber = null)

Get the list of lines.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeLinesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get the list of lines.
                EdgeLineEntityListing result = apiInstance.GetTelephonyProvidersEdgeLines(edgeId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeLines: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**EdgeLineEntityListing**](EdgeLineEntityListing.html)

<a name="gettelephonyprovidersedgelogicalinterface"></a>

## [**DomainLogicalInterface**](DomainLogicalInterface.html) GetTelephonyProvidersEdgeLogicalinterface (string edgeId, string interfaceId, List<string> expand = null)

Get an edge logical interface



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeLogicalinterfaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID
            var expand = new List<string>(); // List<string> | Field to expand in the response (optional) 

            try
            {
                // Get an edge logical interface
                DomainLogicalInterface result = apiInstance.GetTelephonyProvidersEdgeLogicalinterface(edgeId, interfaceId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeLogicalinterface: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
| **expand** | [**List<string>**](string.html)| Field to expand in the response | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface.html)

<a name="gettelephonyprovidersedgelogicalinterfaces"></a>

## [**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing.html) GetTelephonyProvidersEdgeLogicalinterfaces (string edgeId, List<string> expand = null)

Get edge logical interfaces.

Retrieve a list of all configured logical interfaces from a specific edge.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeLogicalinterfacesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var expand = new List<string>(); // List<string> | Field to expand in the response (optional) 

            try
            {
                // Get edge logical interfaces.
                LogicalInterfaceEntityListing result = apiInstance.GetTelephonyProvidersEdgeLogicalinterfaces(edgeId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeLogicalinterfaces: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **expand** | [**List<string>**](string.html)| Field to expand in the response | [optional]  |
{: class="table table-striped"}

### Return type

[**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing.html)

<a name="gettelephonyprovidersedgelogsjob"></a>

## [**EdgeLogsJob**](EdgeLogsJob.html) GetTelephonyProvidersEdgeLogsJob (string edgeId, string jobId)

Get an Edge logs job.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeLogsJobExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var jobId = jobId_example;  // string | Job ID

            try
            {
                // Get an Edge logs job.
                EdgeLogsJob result = apiInstance.GetTelephonyProvidersEdgeLogsJob(edgeId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeLogsJob: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **jobId** | **string**| Job ID |  |
{: class="table table-striped"}

### Return type

[**EdgeLogsJob**](EdgeLogsJob.html)

<a name="gettelephonyprovidersedgephysicalinterface"></a>

## [**DomainPhysicalInterface**](DomainPhysicalInterface.html) GetTelephonyProvidersEdgePhysicalinterface (string edgeId, string interfaceId)

Get edge physical interface.

Retrieve a physical interface from a specific edge.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgePhysicalinterfaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID

            try
            {
                // Get edge physical interface.
                DomainPhysicalInterface result = apiInstance.GetTelephonyProvidersEdgePhysicalinterface(edgeId, interfaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgePhysicalinterface: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
{: class="table table-striped"}

### Return type

[**DomainPhysicalInterface**](DomainPhysicalInterface.html)

<a name="gettelephonyprovidersedgephysicalinterfaces"></a>

## [**PhysicalInterfaceEntityListing**](PhysicalInterfaceEntityListing.html) GetTelephonyProvidersEdgePhysicalinterfaces (string edgeId)

Retrieve a list of all configured physical interfaces from a specific edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgePhysicalinterfacesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Retrieve a list of all configured physical interfaces from a specific edge.
                PhysicalInterfaceEntityListing result = apiInstance.GetTelephonyProvidersEdgePhysicalinterfaces(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgePhysicalinterfaces: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**PhysicalInterfaceEntityListing**](PhysicalInterfaceEntityListing.html)

<a name="gettelephonyprovidersedgesetuppackage"></a>

## [**VmPairingInfo**](VmPairingInfo.html) GetTelephonyProvidersEdgeSetuppackage (string edgeId)

Get the setup package for a locally deployed edge device. This is needed to complete the setup process for the virtual edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeSetuppackageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Get the setup package for a locally deployed edge device. This is needed to complete the setup process for the virtual edge.
                VmPairingInfo result = apiInstance.GetTelephonyProvidersEdgeSetuppackage(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeSetuppackage: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**VmPairingInfo**](VmPairingInfo.html)

<a name="gettelephonyprovidersedgesoftwareupdate"></a>

## [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html) GetTelephonyProvidersEdgeSoftwareupdate (string edgeId)

Gets software update status information about any edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeSoftwareupdateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Gets software update status information about any edge.
                DomainEdgeSoftwareUpdateDto result = apiInstance.GetTelephonyProvidersEdgeSoftwareupdate(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeSoftwareupdate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html)

<a name="gettelephonyprovidersedgesoftwareversions"></a>

## [**DomainEdgeSoftwareVersionDtoEntityListing**](DomainEdgeSoftwareVersionDtoEntityListing.html) GetTelephonyProvidersEdgeSoftwareversions (string edgeId)

Gets all the available software versions for this edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeSoftwareversionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Gets all the available software versions for this edge.
                DomainEdgeSoftwareVersionDtoEntityListing result = apiInstance.GetTelephonyProvidersEdgeSoftwareversions(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeSoftwareversions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**DomainEdgeSoftwareVersionDtoEntityListing**](DomainEdgeSoftwareVersionDtoEntityListing.html)

<a name="gettelephonyprovidersedges"></a>

## [**EdgeEntityListing**](EdgeEntityListing.html) GetTelephonyProvidersEdges (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null, bool? managed = null)

Get the list of edges.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var siteId = siteId_example;  // string | Filter by site.id (optional) 
            var edgeGroupId = edgeGroupId_example;  // string | Filter by edgeGroup.id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var managed = true;  // bool? | Filter by managed (optional) 

            try
            {
                // Get the list of edges.
                EdgeEntityListing result = apiInstance.GetTelephonyProvidersEdges(pageSize, pageNumber, name, siteId, edgeGroupId, sortBy, managed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdges: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **siteId** | **string**| Filter by site.id | [optional]  |
| **edgeGroupId** | **string**| Filter by edgeGroup.id | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **managed** | **bool?**| Filter by managed | [optional]  |
{: class="table table-striped"}

### Return type

[**EdgeEntityListing**](EdgeEntityListing.html)

<a name="gettelephonyprovidersedgesavailablelanguages"></a>

## [**AvailableLanguageList**](AvailableLanguageList.html) GetTelephonyProvidersEdgesAvailablelanguages ()

Get the list of available languages.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesAvailablelanguagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();

            try
            {
                // Get the list of available languages.
                AvailableLanguageList result = apiInstance.GetTelephonyProvidersEdgesAvailablelanguages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesAvailablelanguages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**AvailableLanguageList**](AvailableLanguageList.html)

<a name="gettelephonyprovidersedgescertificateauthorities"></a>

## [**CertificateAuthorityEntityListing**](CertificateAuthorityEntityListing.html) GetTelephonyProvidersEdgesCertificateauthorities ()

Get the list of certificate authorities.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesCertificateauthoritiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();

            try
            {
                // Get the list of certificate authorities.
                CertificateAuthorityEntityListing result = apiInstance.GetTelephonyProvidersEdgesCertificateauthorities();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesCertificateauthorities: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**CertificateAuthorityEntityListing**](CertificateAuthorityEntityListing.html)

<a name="gettelephonyprovidersedgescertificateauthority"></a>

## [**DomainCertificateAuthority**](DomainCertificateAuthority.html) GetTelephonyProvidersEdgesCertificateauthority (string certificateId)

Get a certificate authority.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesCertificateauthorityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var certificateId = certificateId_example;  // string | Certificate ID

            try
            {
                // Get a certificate authority.
                DomainCertificateAuthority result = apiInstance.GetTelephonyProvidersEdgesCertificateauthority(certificateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesCertificateauthority: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |
{: class="table table-striped"}

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority.html)

<a name="gettelephonyprovidersedgesdid"></a>

## [**DID**](DID.html) GetTelephonyProvidersEdgesDid (string didId)

Get a DID by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesDidExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didId = didId_example;  // string | DID ID

            try
            {
                // Get a DID by ID.
                DID result = apiInstance.GetTelephonyProvidersEdgesDid(didId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesDid: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didId** | **string**| DID ID |  |
{: class="table table-striped"}

### Return type

[**DID**](DID.html)

<a name="gettelephonyprovidersedgesdidpool"></a>

## [**DIDPool**](DIDPool.html) GetTelephonyProvidersEdgesDidpool (string didPoolId)

Get a DID Pool by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesDidpoolExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID

            try
            {
                // Get a DID Pool by ID.
                DIDPool result = apiInstance.GetTelephonyProvidersEdgesDidpool(didPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesDidpool: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |
{: class="table table-striped"}

### Return type

[**DIDPool**](DIDPool.html)

<a name="gettelephonyprovidersedgesdidpools"></a>

## [**DIDPoolEntityListing**](DIDPoolEntityListing.html) GetTelephonyProvidersEdgesDidpools (int? pageSize = null, int? pageNumber = null, string sortBy = null)

Get a listing of DID Pools



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesDidpoolsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to number)

            try
            {
                // Get a listing of DID Pools
                DIDPoolEntityListing result = apiInstance.GetTelephonyProvidersEdgesDidpools(pageSize, pageNumber, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesDidpools: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to number] |
{: class="table table-striped"}

### Return type

[**DIDPoolEntityListing**](DIDPoolEntityListing.html)

<a name="gettelephonyprovidersedgesdids"></a>

## [**DIDEntityListing**](DIDEntityListing.html) GetTelephonyProvidersEdgesDids (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)

Get a listing of DIDs



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesDidsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to number)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var phoneNumber = phoneNumber_example;  // string | Filter by phoneNumber (optional) 

            try
            {
                // Get a listing of DIDs
                DIDEntityListing result = apiInstance.GetTelephonyProvidersEdgesDids(pageSize, pageNumber, sortBy, sortOrder, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesDids: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to number] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **phoneNumber** | **string**| Filter by phoneNumber | [optional]  |
{: class="table table-striped"}

### Return type

[**DIDEntityListing**](DIDEntityListing.html)

<a name="gettelephonyprovidersedgesedgegroup"></a>

## [**EdgeGroup**](EdgeGroup.html) GetTelephonyProvidersEdgesEdgegroup (string edgeGroupId, List<string> expand = null)

Get edge group.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesEdgegroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID
            var expand = new List<string>(); // List<string> | Fields to expand in the response (optional) 

            try
            {
                // Get edge group.
                EdgeGroup result = apiInstance.GetTelephonyProvidersEdgesEdgegroup(edgeGroupId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesEdgegroup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
| **expand** | [**List<string>**](string.html)| Fields to expand in the response | [optional]  |
{: class="table table-striped"}

### Return type

[**EdgeGroup**](EdgeGroup.html)

<a name="gettelephonyprovidersedgesedgegroupedgetrunkbasis"></a>

## [**EdgeTrunkBase**](EdgeTrunkBase.html) GetTelephonyProvidersEdgesEdgegroupEdgetrunkbasis (string edgegroupId, string edgetrunkbaseId)

Gets the edge trunk base associated with the edge group



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesEdgegroupEdgetrunkbasisExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgegroupId = edgegroupId_example;  // string | Edge Group ID
            var edgetrunkbaseId = edgetrunkbaseId_example;  // string | Edge Trunk Base ID

            try
            {
                // Gets the edge trunk base associated with the edge group
                EdgeTrunkBase result = apiInstance.GetTelephonyProvidersEdgesEdgegroupEdgetrunkbasis(edgegroupId, edgetrunkbaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesEdgegroupEdgetrunkbasis: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgegroupId** | **string**| Edge Group ID |  |
| **edgetrunkbaseId** | **string**| Edge Trunk Base ID |  |
{: class="table table-striped"}

### Return type

[**EdgeTrunkBase**](EdgeTrunkBase.html)

<a name="gettelephonyprovidersedgesedgegroups"></a>

## [**EdgeGroupEntityListing**](EdgeGroupEntityListing.html) GetTelephonyProvidersEdgesEdgegroups (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, bool? managed = null)

Get the list of edge groups.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesEdgegroupsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var managed = true;  // bool? | Filter by managed (optional) 

            try
            {
                // Get the list of edge groups.
                EdgeGroupEntityListing result = apiInstance.GetTelephonyProvidersEdgesEdgegroups(pageSize, pageNumber, name, sortBy, managed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesEdgegroups: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **managed** | **bool?**| Filter by managed | [optional]  |
{: class="table table-striped"}

### Return type

[**EdgeGroupEntityListing**](EdgeGroupEntityListing.html)

<a name="gettelephonyprovidersedgesedgeversionreport"></a>

## [**EdgeVersionReport**](EdgeVersionReport.html) GetTelephonyProvidersEdgesEdgeversionreport ()

Get the edge version report.

The report will not have consistent data about the edge version(s) until all edges have been reset.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesEdgeversionreportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();

            try
            {
                // Get the edge version report.
                EdgeVersionReport result = apiInstance.GetTelephonyProvidersEdgesEdgeversionreport();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesEdgeversionreport: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**EdgeVersionReport**](EdgeVersionReport.html)

<a name="gettelephonyprovidersedgesendpoint"></a>

## [**Endpoint**](Endpoint.html) GetTelephonyProvidersEdgesEndpoint (string endpointId)

Get endpoint



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesEndpointExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var endpointId = endpointId_example;  // string | Endpoint ID

            try
            {
                // Get endpoint
                Endpoint result = apiInstance.GetTelephonyProvidersEdgesEndpoint(endpointId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesEndpoint: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **endpointId** | **string**| Endpoint ID |  |
{: class="table table-striped"}

### Return type

[**Endpoint**](Endpoint.html)

<a name="gettelephonyprovidersedgesendpoints"></a>

## [**EndpointEntityListing**](EndpointEntityListing.html) GetTelephonyProvidersEdgesEndpoints (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)

Get endpoints



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesEndpointsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)

            try
            {
                // Get endpoints
                EndpointEntityListing result = apiInstance.GetTelephonyProvidersEdgesEndpoints(pageSize, pageNumber, name, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesEndpoints: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
{: class="table table-striped"}

### Return type

[**EndpointEntityListing**](EndpointEntityListing.html)

<a name="gettelephonyprovidersedgesextension"></a>

## [**Extension**](Extension.html) GetTelephonyProvidersEdgesExtension (string extensionId)

Get an extension by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesExtensionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionId = extensionId_example;  // string | Extension ID

            try
            {
                // Get an extension by ID.
                Extension result = apiInstance.GetTelephonyProvidersEdgesExtension(extensionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesExtension: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionId** | **string**| Extension ID |  |
{: class="table table-striped"}

### Return type

[**Extension**](Extension.html)

<a name="gettelephonyprovidersedgesextensionpool"></a>

## [**ExtensionPool**](ExtensionPool.html) GetTelephonyProvidersEdgesExtensionpool (string extensionPoolId)

Get an extension pool by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesExtensionpoolExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID

            try
            {
                // Get an extension pool by ID
                ExtensionPool result = apiInstance.GetTelephonyProvidersEdgesExtensionpool(extensionPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesExtensionpool: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |
{: class="table table-striped"}

### Return type

[**ExtensionPool**](ExtensionPool.html)

<a name="gettelephonyprovidersedgesextensionpools"></a>

## [**ExtensionPoolEntityListing**](ExtensionPoolEntityListing.html) GetTelephonyProvidersEdgesExtensionpools (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)

Get a listing of extension pools



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesExtensionpoolsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to startNumber)
            var number = number_example;  // string | Number (optional) 

            try
            {
                // Get a listing of extension pools
                ExtensionPoolEntityListing result = apiInstance.GetTelephonyProvidersEdgesExtensionpools(pageSize, pageNumber, sortBy, number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesExtensionpools: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to startNumber] |
| **number** | **string**| Number | [optional]  |
{: class="table table-striped"}

### Return type

[**ExtensionPoolEntityListing**](ExtensionPoolEntityListing.html)

<a name="gettelephonyprovidersedgesextensions"></a>

## [**ExtensionEntityListing**](ExtensionEntityListing.html) GetTelephonyProvidersEdgesExtensions (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)

Get a listing of extensions



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesExtensionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to number)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var number = number_example;  // string | Filter by number (optional) 

            try
            {
                // Get a listing of extensions
                ExtensionEntityListing result = apiInstance.GetTelephonyProvidersEdgesExtensions(pageSize, pageNumber, sortBy, sortOrder, number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesExtensions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to number] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **number** | **string**| Filter by number | [optional]  |
{: class="table table-striped"}

### Return type

[**ExtensionEntityListing**](ExtensionEntityListing.html)

<a name="gettelephonyprovidersedgesline"></a>

## [**Line**](Line.html) GetTelephonyProvidersEdgesLine (string lineId)

Get a Line by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesLineExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var lineId = lineId_example;  // string | Line ID

            try
            {
                // Get a Line by ID
                Line result = apiInstance.GetTelephonyProvidersEdgesLine(lineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesLine: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lineId** | **string**| Line ID |  |
{: class="table table-striped"}

### Return type

[**Line**](Line.html)

<a name="gettelephonyprovidersedgeslinebasesetting"></a>

## [**LineBase**](LineBase.html) GetTelephonyProvidersEdgesLinebasesetting (string lineBaseId)

Get a line base settings object by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesLinebasesettingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var lineBaseId = lineBaseId_example;  // string | Line base ID

            try
            {
                // Get a line base settings object by ID
                LineBase result = apiInstance.GetTelephonyProvidersEdgesLinebasesetting(lineBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesLinebasesetting: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lineBaseId** | **string**| Line base ID |  |
{: class="table table-striped"}

### Return type

[**LineBase**](LineBase.html)

<a name="gettelephonyprovidersedgeslinebasesettings"></a>

## [**LineBaseEntityListing**](LineBaseEntityListing.html) GetTelephonyProvidersEdgesLinebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)

Get a listing of line base settings objects



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesLinebasesettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)

            try
            {
                // Get a listing of line base settings objects
                LineBaseEntityListing result = apiInstance.GetTelephonyProvidersEdgesLinebasesettings(pageNumber, pageSize, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesLinebasesettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
{: class="table table-striped"}

### Return type

[**LineBaseEntityListing**](LineBaseEntityListing.html)

<a name="gettelephonyprovidersedgeslines"></a>

## [**LineEntityListing**](LineEntityListing.html) GetTelephonyProvidersEdgesLines (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)

Get a list of Lines



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesLinesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to name)
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 

            try
            {
                // Get a list of Lines
                LineEntityListing result = apiInstance.GetTelephonyProvidersEdgesLines(pageSize, pageNumber, name, sortBy, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesLines: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Value by which to sort | [optional] [default to name] |
| **expand** | [**List<string>**](string.html)| Fields to expand in the response, comma-separated | [optional]  |
{: class="table table-striped"}

### Return type

[**LineEntityListing**](LineEntityListing.html)

<a name="gettelephonyprovidersedgeslinestemplate"></a>

## [**Line**](Line.html) GetTelephonyProvidersEdgesLinesTemplate (string lineBaseSettingsId)

Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesLinesTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var lineBaseSettingsId = lineBaseSettingsId_example;  // string | The id of a Line Base Settings object upon which to base this Line

            try
            {
                // Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
                Line result = apiInstance.GetTelephonyProvidersEdgesLinesTemplate(lineBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesLinesTemplate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lineBaseSettingsId** | **string**| The id of a Line Base Settings object upon which to base this Line |  |
{: class="table table-striped"}

### Return type

[**Line**](Line.html)

<a name="gettelephonyprovidersedgeslogicalinterfaces"></a>

## [**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing.html) GetTelephonyProvidersEdgesLogicalinterfaces (string edgeIds, List<string> expand = null)

Get edge logical interfaces.

Retrieve the configured logical interfaces for a list edges. Only 100 edges can be requested at a time.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesLogicalinterfacesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeIds = edgeIds_example;  // string | Comma separated list of Edge Id's
            var expand = new List<string>(); // List<string> | Field to expand in the response (optional) 

            try
            {
                // Get edge logical interfaces.
                LogicalInterfaceEntityListing result = apiInstance.GetTelephonyProvidersEdgesLogicalinterfaces(edgeIds, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesLogicalinterfaces: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeIds** | **string**| Comma separated list of Edge Id&#39;s |  |
| **expand** | [**List<string>**](string.html)| Field to expand in the response | [optional]  |
{: class="table table-striped"}

### Return type

[**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing.html)

<a name="gettelephonyprovidersedgesoutboundroute"></a>

## [**OutboundRoute**](OutboundRoute.html) GetTelephonyProvidersEdgesOutboundroute (string outboundRouteId)

Get outbound route



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesOutboundrouteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID

            try
            {
                // Get outbound route
                OutboundRoute result = apiInstance.GetTelephonyProvidersEdgesOutboundroute(outboundRouteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesOutboundroute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outboundRouteId** | **string**| Outbound route ID |  |
{: class="table table-striped"}

### Return type

[**OutboundRoute**](OutboundRoute.html)

<a name="gettelephonyprovidersedgesoutboundroutes"></a>

## [**OutboundRouteEntityListing**](OutboundRouteEntityListing.html) GetTelephonyProvidersEdgesOutboundroutes (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)

Get outbound routes



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesOutboundroutesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var siteId = siteId_example;  // string | Filter by site.id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)

            try
            {
                // Get outbound routes
                OutboundRouteEntityListing result = apiInstance.GetTelephonyProvidersEdgesOutboundroutes(pageSize, pageNumber, name, siteId, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesOutboundroutes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **siteId** | **string**| Filter by site.id | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
{: class="table table-striped"}

### Return type

[**OutboundRouteEntityListing**](OutboundRouteEntityListing.html)

<a name="gettelephonyprovidersedgesphone"></a>

## [**Phone**](Phone.html) GetTelephonyProvidersEdgesPhone (string phoneId)

Get a Phone by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone ID

            try
            {
                // Get a Phone by ID
                Phone result = apiInstance.GetTelephonyProvidersEdgesPhone(phoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhone: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.html)

<a name="gettelephonyprovidersedgesphonebasesetting"></a>

## [**PhoneBase**](PhoneBase.html) GetTelephonyProvidersEdgesPhonebasesetting (string phoneBaseId)

Get a Phone Base Settings object by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhonebasesettingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseId = phoneBaseId_example;  // string | Phone base ID

            try
            {
                // Get a Phone Base Settings object by ID
                PhoneBase result = apiInstance.GetTelephonyProvidersEdgesPhonebasesetting(phoneBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhonebasesetting: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.html)

<a name="gettelephonyprovidersedgesphonebasesettings"></a>

## [**PhoneBaseEntityListing**](PhoneBaseEntityListing.html) GetTelephonyProvidersEdgesPhonebasesettings (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null)

Get a list of Phone Base Settings objects



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhonebasesettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var name = name_example;  // string | Name (optional) 

            try
            {
                // Get a list of Phone Base Settings objects
                PhoneBaseEntityListing result = apiInstance.GetTelephonyProvidersEdgesPhonebasesettings(pageSize, pageNumber, sortBy, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhonebasesettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**PhoneBaseEntityListing**](PhoneBaseEntityListing.html)

<a name="gettelephonyprovidersedgesphonebasesettingsavailablemetabases"></a>

## [**PhoneMetaBaseEntityListing**](PhoneMetaBaseEntityListing.html) GetTelephonyProvidersEdgesPhonebasesettingsAvailablemetabases (int? pageSize = null, int? pageNumber = null)

Get a list of available makes and models to create a new Phone Base Settings



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhonebasesettingsAvailablemetabasesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get a list of available makes and models to create a new Phone Base Settings
                PhoneMetaBaseEntityListing result = apiInstance.GetTelephonyProvidersEdgesPhonebasesettingsAvailablemetabases(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhonebasesettingsAvailablemetabases: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**PhoneMetaBaseEntityListing**](PhoneMetaBaseEntityListing.html)

<a name="gettelephonyprovidersedgesphonebasesettingstemplate"></a>

## [**PhoneBase**](PhoneBase.html) GetTelephonyProvidersEdgesPhonebasesettingsTemplate (string phoneMetabaseId)

Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhonebasesettingsTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneMetabaseId = phoneMetabaseId_example;  // string | The id of a metabase object upon which to base this Phone Base Settings

            try
            {
                // Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
                PhoneBase result = apiInstance.GetTelephonyProvidersEdgesPhonebasesettingsTemplate(phoneMetabaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhonebasesettingsTemplate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneMetabaseId** | **string**| The id of a metabase object upon which to base this Phone Base Settings |  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.html)

<a name="gettelephonyprovidersedgesphones"></a>

## [**PhoneEntityListing**](PhoneEntityListing.html) GetTelephonyProvidersEdgesPhones (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string webRtcUserId = null, string phoneBaseSettingsId = null, string linesLoggedInUserId = null, string linesDefaultForUserId = null, string phoneHardwareId = null, string linesId = null, string linesName = null, List<string> expand = null, List<string> fields = null)

Get a list of Phone Instances



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhonesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var siteId = siteId_example;  // string | Filter by site.id (optional) 
            var webRtcUserId = webRtcUserId_example;  // string | Filter by webRtcUser.id (optional) 
            var phoneBaseSettingsId = phoneBaseSettingsId_example;  // string | Filter by phoneBaseSettings.id (optional) 
            var linesLoggedInUserId = linesLoggedInUserId_example;  // string | Filter by lines.loggedInUser.id (optional) 
            var linesDefaultForUserId = linesDefaultForUserId_example;  // string | Filter by lines.defaultForUser.id (optional) 
            var phoneHardwareId = phoneHardwareId_example;  // string | Filter by phone_hardwareId (optional) 
            var linesId = linesId_example;  // string | Filter by lines.id (optional) 
            var linesName = linesName_example;  // string | Filter by lines.name (optional) 
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 
            var fields = new List<string>(); // List<string> | Fields and properties to get, comma-separated (optional) 

            try
            {
                // Get a list of Phone Instances
                PhoneEntityListing result = apiInstance.GetTelephonyProvidersEdgesPhones(pageNumber, pageSize, sortBy, sortOrder, siteId, webRtcUserId, phoneBaseSettingsId, linesLoggedInUserId, linesDefaultForUserId, phoneHardwareId, linesId, linesName, expand, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhones: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **siteId** | **string**| Filter by site.id | [optional]  |
| **webRtcUserId** | **string**| Filter by webRtcUser.id | [optional]  |
| **phoneBaseSettingsId** | **string**| Filter by phoneBaseSettings.id | [optional]  |
| **linesLoggedInUserId** | **string**| Filter by lines.loggedInUser.id | [optional]  |
| **linesDefaultForUserId** | **string**| Filter by lines.defaultForUser.id | [optional]  |
| **phoneHardwareId** | **string**| Filter by phone_hardwareId | [optional]  |
| **linesId** | **string**| Filter by lines.id | [optional]  |
| **linesName** | **string**| Filter by lines.name | [optional]  |
| **expand** | [**List<string>**](string.html)| Fields to expand in the response, comma-separated | [optional]  |
| **fields** | [**List<string>**](string.html)| Fields and properties to get, comma-separated | [optional]  |
{: class="table table-striped"}

### Return type

[**PhoneEntityListing**](PhoneEntityListing.html)

<a name="gettelephonyprovidersedgesphonestemplate"></a>

## [**Phone**](Phone.html) GetTelephonyProvidersEdgesPhonesTemplate (string phoneBaseSettingsId)

Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhonesTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseSettingsId = phoneBaseSettingsId_example;  // string | The id of a Phone Base Settings object upon which to base this Phone

            try
            {
                // Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
                Phone result = apiInstance.GetTelephonyProvidersEdgesPhonesTemplate(phoneBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhonesTemplate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseSettingsId** | **string**| The id of a Phone Base Settings object upon which to base this Phone |  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.html)

<a name="gettelephonyprovidersedgessite"></a>

## [**Site**](Site.html) GetTelephonyProvidersEdgesSite (string siteId)

Get a Site by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Get a Site by ID.
                Site result = apiInstance.GetTelephonyProvidersEdgesSite(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSite: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
{: class="table table-striped"}

### Return type

[**Site**](Site.html)

<a name="gettelephonyprovidersedgessitenumberplan"></a>

## [**NumberPlan**](NumberPlan.html) GetTelephonyProvidersEdgesSiteNumberplan (string siteId, string numberPlanId)

Get a Number Plan by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteNumberplanExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var numberPlanId = numberPlanId_example;  // string | Number Plan ID

            try
            {
                // Get a Number Plan by ID.
                NumberPlan result = apiInstance.GetTelephonyProvidersEdgesSiteNumberplan(siteId, numberPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSiteNumberplan: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **numberPlanId** | **string**| Number Plan ID |  |
{: class="table table-striped"}

### Return type

[**NumberPlan**](NumberPlan.html)

<a name="gettelephonyprovidersedgessitenumberplans"></a>

## [**List&lt;NumberPlan&gt;**](NumberPlan.html) GetTelephonyProvidersEdgesSiteNumberplans (string siteId)

Get the list of Number Plans for this Site.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteNumberplansExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Get the list of Number Plans for this Site.
                List&lt;NumberPlan&gt; result = apiInstance.GetTelephonyProvidersEdgesSiteNumberplans(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSiteNumberplans: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
{: class="table table-striped"}

### Return type

[**List<NumberPlan>**](NumberPlan.html)

<a name="gettelephonyprovidersedgessitenumberplansclassifications"></a>

## **List&lt;string&gt;** GetTelephonyProvidersEdgesSiteNumberplansClassifications (string siteId, string classification = null)

Get a list of Classifications for this Site



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteNumberplansClassificationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var classification = classification_example;  // string | Classification (optional) 

            try
            {
                // Get a list of Classifications for this Site
                List&lt;string&gt; result = apiInstance.GetTelephonyProvidersEdgesSiteNumberplansClassifications(siteId, classification);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSiteNumberplansClassifications: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **classification** | **string**| Classification | [optional]  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="gettelephonyprovidersedgessiteoutboundroute"></a>

## [**OutboundRouteBase**](OutboundRouteBase.html) GetTelephonyProvidersEdgesSiteOutboundroute (string siteId, string outboundRouteId)

Get an outbound route



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteOutboundrouteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID

            try
            {
                // Get an outbound route
                OutboundRouteBase result = apiInstance.GetTelephonyProvidersEdgesSiteOutboundroute(siteId, outboundRouteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSiteOutboundroute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **outboundRouteId** | **string**| Outbound route ID |  |
{: class="table table-striped"}

### Return type

[**OutboundRouteBase**](OutboundRouteBase.html)

<a name="gettelephonyprovidersedgessiteoutboundroutes"></a>

## [**OutboundRouteBaseEntityListing**](OutboundRouteBaseEntityListing.html) GetTelephonyProvidersEdgesSiteOutboundroutes (string siteId, int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)

Get outbound routes



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteOutboundroutesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)

            try
            {
                // Get outbound routes
                OutboundRouteBaseEntityListing result = apiInstance.GetTelephonyProvidersEdgesSiteOutboundroutes(siteId, pageSize, pageNumber, name, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSiteOutboundroutes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
{: class="table table-striped"}

### Return type

[**OutboundRouteBaseEntityListing**](OutboundRouteBaseEntityListing.html)

<a name="gettelephonyprovidersedgessites"></a>

## [**SiteEntityListing**](SiteEntityListing.html) GetTelephonyProvidersEdgesSites (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null, bool? managed = null)

Get the list of Sites.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSitesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var name = name_example;  // string | Name (optional) 
            var locationId = locationId_example;  // string | Location Id (optional) 
            var managed = true;  // bool? | Filter by managed (optional) 

            try
            {
                // Get the list of Sites.
                SiteEntityListing result = apiInstance.GetTelephonyProvidersEdgesSites(pageSize, pageNumber, sortBy, sortOrder, name, locationId, managed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSites: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **name** | **string**| Name | [optional]  |
| **locationId** | **string**| Location Id | [optional]  |
| **managed** | **bool?**| Filter by managed | [optional]  |
{: class="table table-striped"}

### Return type

[**SiteEntityListing**](SiteEntityListing.html)

<a name="gettelephonyprovidersedgestimezones"></a>

## [**TimeZoneEntityListing**](TimeZoneEntityListing.html) GetTelephonyProvidersEdgesTimezones (int? pageSize = null, int? pageNumber = null)

Get a list of Edge-compatible time zones



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTimezonesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 1000)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get a list of Edge-compatible time zones
                TimeZoneEntityListing result = apiInstance.GetTelephonyProvidersEdgesTimezones(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTimezones: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 1000] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TimeZoneEntityListing**](TimeZoneEntityListing.html)

<a name="gettelephonyprovidersedgestrunk"></a>

## [**Trunk**](Trunk.html) GetTelephonyProvidersEdgesTrunk (string trunkId)

Get a Trunk by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkId = trunkId_example;  // string | Trunk ID

            try
            {
                // Get a Trunk by ID
                Trunk result = apiInstance.GetTelephonyProvidersEdgesTrunk(trunkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunk: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkId** | **string**| Trunk ID |  |
{: class="table table-striped"}

### Return type

[**Trunk**](Trunk.html)

<a name="gettelephonyprovidersedgestrunkbasesetting"></a>

## [**TrunkBase**](TrunkBase.html) GetTelephonyProvidersEdgesTrunkbasesetting (string trunkBaseSettingsId, bool? ignoreHidden = null)

Get a Trunk Base Settings object by ID

Managed properties will not be returned unless the user is assigned the managed:all:all permission.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkbasesettingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkBaseSettingsId = trunkBaseSettingsId_example;  // string | Trunk Base ID
            var ignoreHidden = true;  // bool? | Set this to true to not receive trunk properties that are meant to be hidden or for internal system usage only. (optional) 

            try
            {
                // Get a Trunk Base Settings object by ID
                TrunkBase result = apiInstance.GetTelephonyProvidersEdgesTrunkbasesetting(trunkBaseSettingsId, ignoreHidden);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunkbasesetting: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |
| **ignoreHidden** | **bool?**| Set this to true to not receive trunk properties that are meant to be hidden or for internal system usage only. | [optional]  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.html)

<a name="gettelephonyprovidersedgestrunkbasesettings"></a>

## [**TrunkBaseEntityListing**](TrunkBaseEntityListing.html) GetTelephonyProvidersEdgesTrunkbasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, bool? recordingEnabled = null, bool? ignoreHidden = null, bool? managed = null, List<string> expand = null, string name = null)

Get Trunk Base Settings listing

Managed properties will not be returned unless the user is assigned the managed:all:all permission.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkbasesettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var recordingEnabled = true;  // bool? | Filter trunks by recording enabled (optional) 
            var ignoreHidden = true;  // bool? | Set this to true to not receive trunk properties that are meant to be hidden or for internal system usage only. (optional) 
            var managed = true;  // bool? | Filter by managed (optional) 
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 
            var name = name_example;  // string | Name of the TrunkBase to filter by (optional) 

            try
            {
                // Get Trunk Base Settings listing
                TrunkBaseEntityListing result = apiInstance.GetTelephonyProvidersEdgesTrunkbasesettings(pageNumber, pageSize, sortBy, sortOrder, recordingEnabled, ignoreHidden, managed, expand, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunkbasesettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **recordingEnabled** | **bool?**| Filter trunks by recording enabled | [optional]  |
| **ignoreHidden** | **bool?**| Set this to true to not receive trunk properties that are meant to be hidden or for internal system usage only. | [optional]  |
| **managed** | **bool?**| Filter by managed | [optional]  |
| **expand** | [**List<string>**](string.html)| Fields to expand in the response, comma-separated | [optional]  |
| **name** | **string**| Name of the TrunkBase to filter by | [optional]  |
{: class="table table-striped"}

### Return type

[**TrunkBaseEntityListing**](TrunkBaseEntityListing.html)

<a name="gettelephonyprovidersedgestrunkbasesettingsavailablemetabases"></a>

## [**TrunkMetabaseEntityListing**](TrunkMetabaseEntityListing.html) GetTelephonyProvidersEdgesTrunkbasesettingsAvailablemetabases (string type = null, int? pageSize = null, int? pageNumber = null)

Get a list of available makes and models to create a new Trunk Base Settings



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkbasesettingsAvailablemetabasesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var type = type_example;  // string |  (optional) 
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var pageNumber = 56;  // int? |  (optional)  (default to 1)

            try
            {
                // Get a list of available makes and models to create a new Trunk Base Settings
                TrunkMetabaseEntityListing result = apiInstance.GetTelephonyProvidersEdgesTrunkbasesettingsAvailablemetabases(type, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunkbasesettingsAvailablemetabases: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**|  | [optional]  |
| **pageSize** | **int?**|  | [optional] [default to 25] |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TrunkMetabaseEntityListing**](TrunkMetabaseEntityListing.html)

<a name="gettelephonyprovidersedgestrunkbasesettingstemplate"></a>

## [**TrunkBase**](TrunkBase.html) GetTelephonyProvidersEdgesTrunkbasesettingsTemplate (string trunkMetabaseId)

Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkbasesettingsTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkMetabaseId = trunkMetabaseId_example;  // string | The id of a metabase object upon which to base this Trunk Base Settings

            try
            {
                // Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
                TrunkBase result = apiInstance.GetTelephonyProvidersEdgesTrunkbasesettingsTemplate(trunkMetabaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunkbasesettingsTemplate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkMetabaseId** | **string**| The id of a metabase object upon which to base this Trunk Base Settings |  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.html)

<a name="gettelephonyprovidersedgestrunks"></a>

## [**TrunkEntityListing**](TrunkEntityListing.html) GetTelephonyProvidersEdgesTrunks (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string edgeId = null, string trunkBaseId = null, string trunkType = null)

Get the list of available trunks.

Trunks are created by assigning trunk base settings to an Edge or Edge Group.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var edgeId = edgeId_example;  // string | Filter by Edge Ids (optional) 
            var trunkBaseId = trunkBaseId_example;  // string | Filter by Trunk Base Ids (optional) 
            var trunkType = trunkType_example;  // string | Filter by a Trunk type (optional) 

            try
            {
                // Get the list of available trunks.
                TrunkEntityListing result = apiInstance.GetTelephonyProvidersEdgesTrunks(pageNumber, pageSize, sortBy, sortOrder, edgeId, trunkBaseId, trunkType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunks: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **edgeId** | **string**| Filter by Edge Ids | [optional]  |
| **trunkBaseId** | **string**| Filter by Trunk Base Ids | [optional]  |
| **trunkType** | **string**| Filter by a Trunk type | [optional]  |
{: class="table table-striped"}

### Return type

[**TrunkEntityListing**](TrunkEntityListing.html)

<a name="gettelephonyprovidersedgestrunkswithrecording"></a>

## [**TrunkRecordingEnabledCount**](TrunkRecordingEnabledCount.html) GetTelephonyProvidersEdgesTrunkswithrecording (string trunkType = null)

Get Counts of trunks that have recording disabled or enabled



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkswithrecordingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkType = trunkType_example;  // string | The type of this trunk base. (optional) 

            try
            {
                // Get Counts of trunks that have recording disabled or enabled
                TrunkRecordingEnabledCount result = apiInstance.GetTelephonyProvidersEdgesTrunkswithrecording(trunkType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunkswithrecording: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkType** | **string**| The type of this trunk base. | [optional]  |
{: class="table table-striped"}

### Return type

[**TrunkRecordingEnabledCount**](TrunkRecordingEnabledCount.html)

<a name="posttelephonyprovidersedgelogicalinterfaces"></a>

## [**DomainLogicalInterface**](DomainLogicalInterface.html) PostTelephonyProvidersEdgeLogicalinterfaces (string edgeId, DomainLogicalInterface body)

Create an edge logical interface.

Create

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeLogicalinterfacesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new DomainLogicalInterface(); // DomainLogicalInterface | Logical interface

            try
            {
                // Create an edge logical interface.
                DomainLogicalInterface result = apiInstance.PostTelephonyProvidersEdgeLogicalinterfaces(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeLogicalinterfaces: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**DomainLogicalInterface**](DomainLogicalInterface.html)| Logical interface |  |
{: class="table table-striped"}

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface.html)

<a name="posttelephonyprovidersedgelogsjobupload"></a>

## void PostTelephonyProvidersEdgeLogsJobUpload (string edgeId, string jobId, EdgeLogsJobUploadRequest body)

Request that the specified fileIds be uploaded from the Edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeLogsJobUploadExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var jobId = jobId_example;  // string | Job ID
            var body = new EdgeLogsJobUploadRequest(); // EdgeLogsJobUploadRequest | Log upload request

            try
            {
                // Request that the specified fileIds be uploaded from the Edge.
                apiInstance.PostTelephonyProvidersEdgeLogsJobUpload(edgeId, jobId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeLogsJobUpload: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **jobId** | **string**| Job ID |  |
| **body** | [**EdgeLogsJobUploadRequest**](EdgeLogsJobUploadRequest.html)| Log upload request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="posttelephonyprovidersedgelogsjobs"></a>

## [**EdgeLogsJobResponse**](EdgeLogsJobResponse.html) PostTelephonyProvidersEdgeLogsJobs (string edgeId, EdgeLogsJobRequest body)

Create a job to upload a list of Edge logs.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeLogsJobsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new EdgeLogsJobRequest(); // EdgeLogsJobRequest | EdgeLogsJobRequest

            try
            {
                // Create a job to upload a list of Edge logs.
                EdgeLogsJobResponse result = apiInstance.PostTelephonyProvidersEdgeLogsJobs(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeLogsJobs: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**EdgeLogsJobRequest**](EdgeLogsJobRequest.html)| EdgeLogsJobRequest |  |
{: class="table table-striped"}

### Return type

[**EdgeLogsJobResponse**](EdgeLogsJobResponse.html)

<a name="posttelephonyprovidersedgereboot"></a>

## **string** PostTelephonyProvidersEdgeReboot (string edgeId, EdgeRebootParameters body = null)

Reboot an Edge



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeRebootExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new EdgeRebootParameters(); // EdgeRebootParameters | Parameters for the edge reboot (optional) 

            try
            {
                // Reboot an Edge
                string result = apiInstance.PostTelephonyProvidersEdgeReboot(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeReboot: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**EdgeRebootParameters**](EdgeRebootParameters.html)| Parameters for the edge reboot | [optional]  |
{: class="table table-striped"}

### Return type

**string**

<a name="posttelephonyprovidersedgesoftwareupdate"></a>

## [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html) PostTelephonyProvidersEdgeSoftwareupdate (string edgeId, DomainEdgeSoftwareUpdateDto body)

Starts a software update for this edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeSoftwareupdateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new DomainEdgeSoftwareUpdateDto(); // DomainEdgeSoftwareUpdateDto | Software update request

            try
            {
                // Starts a software update for this edge.
                DomainEdgeSoftwareUpdateDto result = apiInstance.PostTelephonyProvidersEdgeSoftwareupdate(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeSoftwareupdate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html)| Software update request |  |
{: class="table table-striped"}

### Return type

[**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html)

<a name="posttelephonyprovidersedgestatuscode"></a>

## **string** PostTelephonyProvidersEdgeStatuscode (string edgeId, EdgeServiceStateRequest body = null)

Take an Edge in or out of service



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeStatuscodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new EdgeServiceStateRequest(); // EdgeServiceStateRequest | Edge Service State (optional) 

            try
            {
                // Take an Edge in or out of service
                string result = apiInstance.PostTelephonyProvidersEdgeStatuscode(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeStatuscode: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**EdgeServiceStateRequest**](EdgeServiceStateRequest.html)| Edge Service State | [optional]  |
{: class="table table-striped"}

### Return type

**string**

<a name="posttelephonyprovidersedgeunpair"></a>

## **string** PostTelephonyProvidersEdgeUnpair (string edgeId)

Unpair an Edge



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeUnpairExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge Id

            try
            {
                // Unpair an Edge
                string result = apiInstance.PostTelephonyProvidersEdgeUnpair(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeUnpair: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |
{: class="table table-striped"}

### Return type

**string**

<a name="posttelephonyprovidersedges"></a>

## [**Edge**](Edge.html) PostTelephonyProvidersEdges (Edge body)

Create an edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new Edge(); // Edge | Edge

            try
            {
                // Create an edge.
                Edge result = apiInstance.PostTelephonyProvidersEdges(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdges: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Edge**](Edge.html)| Edge |  |
{: class="table table-striped"}

### Return type

[**Edge**](Edge.html)

<a name="posttelephonyprovidersedgesaddressvalidation"></a>

## [**ValidateAddressResponse**](ValidateAddressResponse.html) PostTelephonyProvidersEdgesAddressvalidation (ValidateAddressRequest body)

Validates a street address



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesAddressvalidationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new ValidateAddressRequest(); // ValidateAddressRequest | Address

            try
            {
                // Validates a street address
                ValidateAddressResponse result = apiInstance.PostTelephonyProvidersEdgesAddressvalidation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesAddressvalidation: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ValidateAddressRequest**](ValidateAddressRequest.html)| Address |  |
{: class="table table-striped"}

### Return type

[**ValidateAddressResponse**](ValidateAddressResponse.html)

<a name="posttelephonyprovidersedgescertificateauthorities"></a>

## [**DomainCertificateAuthority**](DomainCertificateAuthority.html) PostTelephonyProvidersEdgesCertificateauthorities (DomainCertificateAuthority body)

Create a certificate authority.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesCertificateauthoritiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new DomainCertificateAuthority(); // DomainCertificateAuthority | CertificateAuthority

            try
            {
                // Create a certificate authority.
                DomainCertificateAuthority result = apiInstance.PostTelephonyProvidersEdgesCertificateauthorities(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesCertificateauthorities: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DomainCertificateAuthority**](DomainCertificateAuthority.html)| CertificateAuthority |  |
{: class="table table-striped"}

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority.html)

<a name="posttelephonyprovidersedgesdidpools"></a>

## [**DIDPool**](DIDPool.html) PostTelephonyProvidersEdgesDidpools (DIDPool body)

Create a new DID pool



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesDidpoolsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new DIDPool(); // DIDPool | DID pool

            try
            {
                // Create a new DID pool
                DIDPool result = apiInstance.PostTelephonyProvidersEdgesDidpools(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesDidpools: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DIDPool**](DIDPool.html)| DID pool |  |
{: class="table table-striped"}

### Return type

[**DIDPool**](DIDPool.html)

<a name="posttelephonyprovidersedgesedgegroups"></a>

## [**EdgeGroup**](EdgeGroup.html) PostTelephonyProvidersEdgesEdgegroups (EdgeGroup body)

Create an edge group.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesEdgegroupsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new EdgeGroup(); // EdgeGroup | EdgeGroup

            try
            {
                // Create an edge group.
                EdgeGroup result = apiInstance.PostTelephonyProvidersEdgesEdgegroups(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesEdgegroups: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EdgeGroup**](EdgeGroup.html)| EdgeGroup |  |
{: class="table table-striped"}

### Return type

[**EdgeGroup**](EdgeGroup.html)

<a name="posttelephonyprovidersedgesendpoints"></a>

## [**Endpoint**](Endpoint.html) PostTelephonyProvidersEdgesEndpoints (Endpoint body)

Create endpoint



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesEndpointsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new Endpoint(); // Endpoint | EndpointTemplate

            try
            {
                // Create endpoint
                Endpoint result = apiInstance.PostTelephonyProvidersEdgesEndpoints(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesEndpoints: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Endpoint**](Endpoint.html)| EndpointTemplate |  |
{: class="table table-striped"}

### Return type

[**Endpoint**](Endpoint.html)

<a name="posttelephonyprovidersedgesextensionpools"></a>

## [**ExtensionPool**](ExtensionPool.html) PostTelephonyProvidersEdgesExtensionpools (ExtensionPool body)

Create a new extension pool



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesExtensionpoolsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new ExtensionPool(); // ExtensionPool | ExtensionPool

            try
            {
                // Create a new extension pool
                ExtensionPool result = apiInstance.PostTelephonyProvidersEdgesExtensionpools(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesExtensionpools: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExtensionPool**](ExtensionPool.html)| ExtensionPool |  |
{: class="table table-striped"}

### Return type

[**ExtensionPool**](ExtensionPool.html)

<a name="posttelephonyprovidersedgesoutboundroutes"></a>

## [**OutboundRoute**](OutboundRoute.html) PostTelephonyProvidersEdgesOutboundroutes (OutboundRoute body)

Create outbound rule



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesOutboundroutesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new OutboundRoute(); // OutboundRoute | OutboundRoute

            try
            {
                // Create outbound rule
                OutboundRoute result = apiInstance.PostTelephonyProvidersEdgesOutboundroutes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesOutboundroutes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OutboundRoute**](OutboundRoute.html)| OutboundRoute |  |
{: class="table table-striped"}

### Return type

[**OutboundRoute**](OutboundRoute.html)

<a name="posttelephonyprovidersedgesphonereboot"></a>

## void PostTelephonyProvidersEdgesPhoneReboot (string phoneId)

Reboot a Phone



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesPhoneRebootExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone Id

            try
            {
                // Reboot a Phone
                apiInstance.PostTelephonyProvidersEdgesPhoneReboot(phoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesPhoneReboot: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="posttelephonyprovidersedgesphonebasesettings"></a>

## [**PhoneBase**](PhoneBase.html) PostTelephonyProvidersEdgesPhonebasesettings (PhoneBase body)

Create a new Phone Base Settings object



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesPhonebasesettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new PhoneBase(); // PhoneBase | Phone base settings

            try
            {
                // Create a new Phone Base Settings object
                PhoneBase result = apiInstance.PostTelephonyProvidersEdgesPhonebasesettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesPhonebasesettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PhoneBase**](PhoneBase.html)| Phone base settings |  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.html)

<a name="posttelephonyprovidersedgesphones"></a>

## [**Phone**](Phone.html) PostTelephonyProvidersEdgesPhones (Phone body)

Create a new Phone



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesPhonesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new Phone(); // Phone | Phone

            try
            {
                // Create a new Phone
                Phone result = apiInstance.PostTelephonyProvidersEdgesPhones(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesPhones: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Phone**](Phone.html)| Phone |  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.html)

<a name="posttelephonyprovidersedgesphonesreboot"></a>

## void PostTelephonyProvidersEdgesPhonesReboot (PhonesReboot body)

Reboot Multiple Phones



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesPhonesRebootExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new PhonesReboot(); // PhonesReboot | Phones

            try
            {
                // Reboot Multiple Phones
                apiInstance.PostTelephonyProvidersEdgesPhonesReboot(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesPhonesReboot: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PhonesReboot**](PhonesReboot.html)| Phones |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="posttelephonyprovidersedgessiteoutboundroutes"></a>

## [**OutboundRouteBase**](OutboundRouteBase.html) PostTelephonyProvidersEdgesSiteOutboundroutes (string siteId, OutboundRouteBase body)

Create outbound route



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesSiteOutboundroutesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new OutboundRouteBase(); // OutboundRouteBase | OutboundRoute

            try
            {
                // Create outbound route
                OutboundRouteBase result = apiInstance.PostTelephonyProvidersEdgesSiteOutboundroutes(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesSiteOutboundroutes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**OutboundRouteBase**](OutboundRouteBase.html)| OutboundRoute |  |
{: class="table table-striped"}

### Return type

[**OutboundRouteBase**](OutboundRouteBase.html)

<a name="posttelephonyprovidersedgessiterebalance"></a>

## void PostTelephonyProvidersEdgesSiteRebalance (string siteId)

Triggers the rebalance operation.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesSiteRebalanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Triggers the rebalance operation.
                apiInstance.PostTelephonyProvidersEdgesSiteRebalance(siteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesSiteRebalance: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="posttelephonyprovidersedgessites"></a>

## [**Site**](Site.html) PostTelephonyProvidersEdgesSites (Site body)

Create a Site.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesSitesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new Site(); // Site | Site

            try
            {
                // Create a Site.
                Site result = apiInstance.PostTelephonyProvidersEdgesSites(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesSites: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Site**](Site.html)| Site |  |
{: class="table table-striped"}

### Return type

[**Site**](Site.html)

<a name="posttelephonyprovidersedgestrunkbasesettings"></a>

## [**TrunkBase**](TrunkBase.html) PostTelephonyProvidersEdgesTrunkbasesettings (TrunkBase body)

Create a Trunk Base Settings object



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesTrunkbasesettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new TrunkBase(); // TrunkBase | Trunk base settings

            try
            {
                // Create a Trunk Base Settings object
                TrunkBase result = apiInstance.PostTelephonyProvidersEdgesTrunkbasesettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesTrunkbasesettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TrunkBase**](TrunkBase.html)| Trunk base settings |  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.html)

<a name="puttelephonyprovidersedge"></a>

## [**Edge**](Edge.html) PutTelephonyProvidersEdge (string edgeId, Edge body)

Update a edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new Edge(); // Edge | Edge

            try
            {
                // Update a edge.
                Edge result = apiInstance.PutTelephonyProvidersEdge(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdge: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**Edge**](Edge.html)| Edge |  |
{: class="table table-striped"}

### Return type

[**Edge**](Edge.html)

<a name="puttelephonyprovidersedgeline"></a>

## [**EdgeLine**](EdgeLine.html) PutTelephonyProvidersEdgeLine (string edgeId, string lineId, EdgeLine body)

Update a line.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgeLineExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var lineId = lineId_example;  // string | Line ID
            var body = new EdgeLine(); // EdgeLine | Line

            try
            {
                // Update a line.
                EdgeLine result = apiInstance.PutTelephonyProvidersEdgeLine(edgeId, lineId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgeLine: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **lineId** | **string**| Line ID |  |
| **body** | [**EdgeLine**](EdgeLine.html)| Line |  |
{: class="table table-striped"}

### Return type

[**EdgeLine**](EdgeLine.html)

<a name="puttelephonyprovidersedgelogicalinterface"></a>

## [**DomainLogicalInterface**](DomainLogicalInterface.html) PutTelephonyProvidersEdgeLogicalinterface (string edgeId, string interfaceId, DomainLogicalInterface body)

Update an edge logical interface.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgeLogicalinterfaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID
            var body = new DomainLogicalInterface(); // DomainLogicalInterface | Logical interface

            try
            {
                // Update an edge logical interface.
                DomainLogicalInterface result = apiInstance.PutTelephonyProvidersEdgeLogicalinterface(edgeId, interfaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgeLogicalinterface: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
| **body** | [**DomainLogicalInterface**](DomainLogicalInterface.html)| Logical interface |  |
{: class="table table-striped"}

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface.html)

<a name="puttelephonyprovidersedgescertificateauthority"></a>

## [**DomainCertificateAuthority**](DomainCertificateAuthority.html) PutTelephonyProvidersEdgesCertificateauthority (string certificateId, DomainCertificateAuthority body)

Update a certificate authority.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesCertificateauthorityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var certificateId = certificateId_example;  // string | Certificate ID
            var body = new DomainCertificateAuthority(); // DomainCertificateAuthority | Certificate authority

            try
            {
                // Update a certificate authority.
                DomainCertificateAuthority result = apiInstance.PutTelephonyProvidersEdgesCertificateauthority(certificateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesCertificateauthority: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |
| **body** | [**DomainCertificateAuthority**](DomainCertificateAuthority.html)| Certificate authority |  |
{: class="table table-striped"}

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority.html)

<a name="puttelephonyprovidersedgesdid"></a>

## [**DID**](DID.html) PutTelephonyProvidersEdgesDid (string didId, DID body)

Update a DID by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesDidExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didId = didId_example;  // string | DID ID
            var body = new DID(); // DID | DID

            try
            {
                // Update a DID by ID.
                DID result = apiInstance.PutTelephonyProvidersEdgesDid(didId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesDid: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didId** | **string**| DID ID |  |
| **body** | [**DID**](DID.html)| DID |  |
{: class="table table-striped"}

### Return type

[**DID**](DID.html)

<a name="puttelephonyprovidersedgesdidpool"></a>

## [**DIDPool**](DIDPool.html) PutTelephonyProvidersEdgesDidpool (string didPoolId, DIDPool body)

Update a DID Pool by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesDidpoolExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID
            var body = new DIDPool(); // DIDPool | DID pool

            try
            {
                // Update a DID Pool by ID.
                DIDPool result = apiInstance.PutTelephonyProvidersEdgesDidpool(didPoolId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesDidpool: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |
| **body** | [**DIDPool**](DIDPool.html)| DID pool |  |
{: class="table table-striped"}

### Return type

[**DIDPool**](DIDPool.html)

<a name="puttelephonyprovidersedgesedgegroup"></a>

## [**EdgeGroup**](EdgeGroup.html) PutTelephonyProvidersEdgesEdgegroup (string edgeGroupId, EdgeGroup body)

Update an edge group.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesEdgegroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID
            var body = new EdgeGroup(); // EdgeGroup | EdgeGroup

            try
            {
                // Update an edge group.
                EdgeGroup result = apiInstance.PutTelephonyProvidersEdgesEdgegroup(edgeGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesEdgegroup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
| **body** | [**EdgeGroup**](EdgeGroup.html)| EdgeGroup |  |
{: class="table table-striped"}

### Return type

[**EdgeGroup**](EdgeGroup.html)

<a name="puttelephonyprovidersedgesedgegroupedgetrunkbasis"></a>

## [**EdgeTrunkBase**](EdgeTrunkBase.html) PutTelephonyProvidersEdgesEdgegroupEdgetrunkbasis (string edgegroupId, string edgetrunkbaseId, EdgeTrunkBase body)

Update the edge trunk base associated with the edge group



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesEdgegroupEdgetrunkbasisExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgegroupId = edgegroupId_example;  // string | Edge Group ID
            var edgetrunkbaseId = edgetrunkbaseId_example;  // string | Edge Trunk Base ID
            var body = new EdgeTrunkBase(); // EdgeTrunkBase | EdgeTrunkBase

            try
            {
                // Update the edge trunk base associated with the edge group
                EdgeTrunkBase result = apiInstance.PutTelephonyProvidersEdgesEdgegroupEdgetrunkbasis(edgegroupId, edgetrunkbaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesEdgegroupEdgetrunkbasis: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgegroupId** | **string**| Edge Group ID |  |
| **edgetrunkbaseId** | **string**| Edge Trunk Base ID |  |
| **body** | [**EdgeTrunkBase**](EdgeTrunkBase.html)| EdgeTrunkBase |  |
{: class="table table-striped"}

### Return type

[**EdgeTrunkBase**](EdgeTrunkBase.html)

<a name="puttelephonyprovidersedgesendpoint"></a>

## [**Endpoint**](Endpoint.html) PutTelephonyProvidersEdgesEndpoint (string endpointId, Endpoint body)

Update endpoint



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesEndpointExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var endpointId = endpointId_example;  // string | Endpoint ID
            var body = new Endpoint(); // Endpoint | EndpointTemplate

            try
            {
                // Update endpoint
                Endpoint result = apiInstance.PutTelephonyProvidersEdgesEndpoint(endpointId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesEndpoint: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **endpointId** | **string**| Endpoint ID |  |
| **body** | [**Endpoint**](Endpoint.html)| EndpointTemplate |  |
{: class="table table-striped"}

### Return type

[**Endpoint**](Endpoint.html)

<a name="puttelephonyprovidersedgesextension"></a>

## [**Extension**](Extension.html) PutTelephonyProvidersEdgesExtension (string extensionId, Extension body)

Update an extension by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesExtensionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionId = extensionId_example;  // string | Extension ID
            var body = new Extension(); // Extension | Extension

            try
            {
                // Update an extension by ID.
                Extension result = apiInstance.PutTelephonyProvidersEdgesExtension(extensionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesExtension: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionId** | **string**| Extension ID |  |
| **body** | [**Extension**](Extension.html)| Extension |  |
{: class="table table-striped"}

### Return type

[**Extension**](Extension.html)

<a name="puttelephonyprovidersedgesextensionpool"></a>

## [**ExtensionPool**](ExtensionPool.html) PutTelephonyProvidersEdgesExtensionpool (string extensionPoolId, ExtensionPool body)

Update an extension pool by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesExtensionpoolExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID
            var body = new ExtensionPool(); // ExtensionPool | ExtensionPool

            try
            {
                // Update an extension pool by ID
                ExtensionPool result = apiInstance.PutTelephonyProvidersEdgesExtensionpool(extensionPoolId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesExtensionpool: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |
| **body** | [**ExtensionPool**](ExtensionPool.html)| ExtensionPool |  |
{: class="table table-striped"}

### Return type

[**ExtensionPool**](ExtensionPool.html)

<a name="puttelephonyprovidersedgesoutboundroute"></a>

## [**OutboundRoute**](OutboundRoute.html) PutTelephonyProvidersEdgesOutboundroute (string outboundRouteId, OutboundRoute body)

Update outbound route



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesOutboundrouteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID
            var body = new OutboundRoute(); // OutboundRoute | OutboundRoute

            try
            {
                // Update outbound route
                OutboundRoute result = apiInstance.PutTelephonyProvidersEdgesOutboundroute(outboundRouteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesOutboundroute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outboundRouteId** | **string**| Outbound route ID |  |
| **body** | [**OutboundRoute**](OutboundRoute.html)| OutboundRoute |  |
{: class="table table-striped"}

### Return type

[**OutboundRoute**](OutboundRoute.html)

<a name="puttelephonyprovidersedgesphone"></a>

## [**Phone**](Phone.html) PutTelephonyProvidersEdgesPhone (string phoneId, Phone body)

Update a Phone by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesPhoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone ID
            var body = new Phone(); // Phone | Phone

            try
            {
                // Update a Phone by ID
                Phone result = apiInstance.PutTelephonyProvidersEdgesPhone(phoneId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesPhone: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |
| **body** | [**Phone**](Phone.html)| Phone |  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.html)

<a name="puttelephonyprovidersedgesphonebasesetting"></a>

## [**PhoneBase**](PhoneBase.html) PutTelephonyProvidersEdgesPhonebasesetting (string phoneBaseId, PhoneBase body)

Update a Phone Base Settings by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesPhonebasesettingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseId = phoneBaseId_example;  // string | Phone base ID
            var body = new PhoneBase(); // PhoneBase | Phone base settings

            try
            {
                // Update a Phone Base Settings by ID
                PhoneBase result = apiInstance.PutTelephonyProvidersEdgesPhonebasesetting(phoneBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesPhonebasesetting: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |
| **body** | [**PhoneBase**](PhoneBase.html)| Phone base settings |  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.html)

<a name="puttelephonyprovidersedgessite"></a>

## [**Site**](Site.html) PutTelephonyProvidersEdgesSite (string siteId, Site body)

Update a Site by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesSiteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new Site(); // Site | Site

            try
            {
                // Update a Site by ID.
                Site result = apiInstance.PutTelephonyProvidersEdgesSite(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesSite: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**Site**](Site.html)| Site |  |
{: class="table table-striped"}

### Return type

[**Site**](Site.html)

<a name="puttelephonyprovidersedgessitenumberplans"></a>

## [**List&lt;NumberPlan&gt;**](NumberPlan.html) PutTelephonyProvidersEdgesSiteNumberplans (string siteId, List<NumberPlan> body)

Update the list of Number Plans.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesSiteNumberplansExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new List<NumberPlan>(); // List<NumberPlan> | List of number plans

            try
            {
                // Update the list of Number Plans.
                List&lt;NumberPlan&gt; result = apiInstance.PutTelephonyProvidersEdgesSiteNumberplans(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesSiteNumberplans: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**List<NumberPlan>**](NumberPlan.html)| List of number plans |  |
{: class="table table-striped"}

### Return type

[**List<NumberPlan>**](NumberPlan.html)

<a name="puttelephonyprovidersedgessiteoutboundroute"></a>

## [**OutboundRouteBase**](OutboundRouteBase.html) PutTelephonyProvidersEdgesSiteOutboundroute (string siteId, string outboundRouteId, OutboundRouteBase body)

Update outbound route



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesSiteOutboundrouteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID
            var body = new OutboundRouteBase(); // OutboundRouteBase | OutboundRoute

            try
            {
                // Update outbound route
                OutboundRouteBase result = apiInstance.PutTelephonyProvidersEdgesSiteOutboundroute(siteId, outboundRouteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesSiteOutboundroute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **outboundRouteId** | **string**| Outbound route ID |  |
| **body** | [**OutboundRouteBase**](OutboundRouteBase.html)| OutboundRoute |  |
{: class="table table-striped"}

### Return type

[**OutboundRouteBase**](OutboundRouteBase.html)

<a name="puttelephonyprovidersedgestrunkbasesetting"></a>

## [**TrunkBase**](TrunkBase.html) PutTelephonyProvidersEdgesTrunkbasesetting (string trunkBaseSettingsId, TrunkBase body)

Update a Trunk Base Settings object by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesTrunkbasesettingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkBaseSettingsId = trunkBaseSettingsId_example;  // string | Trunk Base ID
            var body = new TrunkBase(); // TrunkBase | Trunk base settings

            try
            {
                // Update a Trunk Base Settings object by ID
                TrunkBase result = apiInstance.PutTelephonyProvidersEdgesTrunkbasesetting(trunkBaseSettingsId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesTrunkbasesetting: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |
| **body** | [**TrunkBase**](TrunkBase.html)| Trunk base settings |  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.html)
