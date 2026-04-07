## Description
This file describes customization hooks that can be used to generate custom code.

### Name: excludeFromMarshalling 
### Type: string[]
- Description: The excludeFromMarshalling customization hook is used within the shapeModifiers object to exclude a member from being marshalled on the request side. This will still include the property in the POCO but it just will skip the marshalling logic. excludeFromMarshalling is an array of members that should be excluded
from marshalling.
- Example Usage:
``` json
 "shapeModifiers":{
    "CopyObjectRequest":{
        "excludeFromMarshalling":[
            "Metadata"
        ]
    }
 }
```

### Name: excludeFromUnmarshalling
### Type: string[]
- Description: The excludeFromUnmarshalling customization hook is used to exclude members from being unmarshalled on the response side. 
- Example Usage:
```json
"shapeModifiers":{
    "S3Grantee":{
        "excludeFromUnmarshalling":[
            "Type"
        ]
    }
}
```

### Name: skipXmlTestExpression
### Type: string[]
- Description: The skipXmlTestExpression customization hook is used to skip the `testExpression` statement that exists in xml unmarshalling. This customization only skips the testExpression check, it does not skip the logic within the `testExpression` statement.
- Example Usage:
```json
 "shapeModifiers":{
    "GetBucketLifecycleConfigurationOutput":{
        "skipXmlTestExpression":[
            "Configuration"
        ]
    }
 }
```

### Name: originalMemberIsOutsideContainingShape | outsideOriginalMember
### Type: bool, string
- Description: The `originalMemberIsOutsideContainingShape` and `outsideOriginalMember` customization hooks are used together to inject a member from another shape to the current shape. If `originalMemberIsOutsideContainingShape` is set to true, then the `outsideOriginalMember` is specified as a comma-separated string of the shape path. This is used within the "inject" key which injects a member into the shape. In the following example, the member "Configuration" is injected into `GetBucketLifecycleConfigurationOutput` where the original member is `LifecycleConfiguration` on `PutBucketLifecycleConfigurationRequest`. This is a rare customization used to account for use cases where one shape is shared between two shapes, often a Configuration object.
- Example Usage:
```json
 "shapeModifiers":{
    "GetBucketLifecycleConfigurationOutput":{
        "inject":[
            {
                "Configuration" : {
                    "shape": "LifecycleConfiguration",
                    "originalMemberIsOutsideContainingShape":true,
                    "outsideOriginalMember":"PutBucketLifecycleConfigurationRequest,LifecycleConfiguration"
                }
            }
        ],
        "skipXmlTestExpression":[
            "Configuration"
        ]
    }
 }
```

### Name: injectXmlUnmarshallCode | skipContextTestExpressionUnmarshallingLogic
### Type: string[], bool
- Description: These two customization hooks are often used together to skip the unmarshalling logic within an xml `testExpression` block and to inject custom code instead. Set `skipContextTestExpressionUnmarshallingLogic` to `true` and specify what you want to inject via `injectXmlUnmarshallCode`. Though an array of code can be injected, it is best practice to inject a method and in a custom partial class, define that method. 
- Example Usage:
```json
"shapeModifiers":{
    "ListObjectVersionsOutput":{
        "modify" : [
            {
                "EncodingType" : {"emitPropertyName" : "Encoding"}
            },
            {
                "DeleteMarkers" : {
                    "skipContextTestExpressionUnmarshallingLogic" : true,
                    "injectXmlUnmarshallCode" :[
                        "DeleteItemCustomUnmarshall(context, response);"
                    ]
                }
            },
            {
                "Versions":{
                    "skipContextTestExpressionUnmarshallingLogic" : true,
                    "injectXmlUnmarshallCode" :[
                        "VersionsItemCustomUnmarshall(context, response);"
                    ]
                }
            }      
        ]
    }
}
```

### Name: injectXmlMarshallCodeInPayload
### Type: string[]
- Description: For operations where an xml payload is sent, there are times when you must inject some code into the payload to do some work such as sort a parts list or do custom region handling. This logic will be executed in the first line of code during xml payload marshalling. This is perfect for custom logic that isn't tied to any specific member, but must be executed before any xml writing begins.
- Example Usage:
```json
"shapeModifiers":{
    "CompleteMultipartUploadRequest": {
        "modify":[
            {
                "IfMatch": {"injectXmlIsSet":["return !string.IsNullOrEmpty(this._ifMatch);"]}
            },
            {
                "ExpectedBucketOwner": {"injectXmlIsSet":["return !string.IsNullOrEmpty(this._expectedBucketOwner);"]}
            },
            {
                "IfNoneMatch": {"injectXmlIsSet":["return !string.IsNullOrEmpty(this._ifNoneMatch);"]}
            },
            {
                "Parts":{"emitPropertyName":"PartETags"}
            }
        ],
        "injectXmlMarshallCodeInPayload":[
            "SortPartsList(publicRequest);"
        ]
    }
}
```

### Name: injectXmlUnmarshallResultCode
### Type: string[]
- Description: This customization hook is used for operations where code needs to be injected in the unmarshallResult method and isn't tied to a specific member. This customization hook will inject code right before the `context.Read()` call. 
- Example Usage:
```json
"shapeModifiers":{
    "GetBucketWebsiteOutput":{
        "injectXmlUnmarshallResultCode":["response.WebsiteConfiguration = new WebsiteConfiguration();"]
    }
}
```

### Name: injectXmlIsSet
### Type: string[]
- Description: This customization hook is used for operations where code needs to be injected in the `IsSet` method for a given member. This code will replace whatever normally is written inside of `IsSet`.
- Example Usage:
```json
"shapeModifiers":{
    "PutBucketWebsiteRequest":{
        "modify":[
            {
                "ExpectedBucketOwner":{"injectXmlIsSet":["return !String.IsNullOrEmpty(this._expectedBucketOwner);"]}
            }
        ]
    }
}
```

### Name: injectXmlPrivateMemberAssignment
### Type: string[]
- Description: This customization hook is used to set a default value for a private variable. Instead of the typical pattern of `private string _bucketName;`, for example, you could inject a default like `private string _bucketName = "hello-world";`.
- Example Usage:
```json
"shapeModifiers":{
    "InputSerialization":{
        "modify":[
            {
                "CompressionType":{
                    "injectXmlPrivateMemberAssignment" :["private CompressionType _compressionType = CompressionType.None;"]
                }
            }
        ]
    }
}
```

### Name: injectXmlPropertyGetter 
### Type: string[]
- Description: Though the name suggests that this can only be used for XML based services, this isn't true. This can be used for any protocol. This customization hook is used to inject code into the getter of a property. This will completely replace the getter with the code specified in the string array.
- Example Usage:
```json
"shapeModifiers":{
    "S3Grantee":{
        "modify":[
            {
                "Type":{
                    "injectXmlPropertyGetter":[
                        "get { return GranteeTypeGetter();}"
                    ]
                }
            }
        ]
    }
}
```

### Name: injectXmlPropertySetter
### Type: string[]
- Description: Though the name suggests that this can only be used for XML based services, this isn't true. This can be used for any protocol. This customization hook is used to inject code into the setter of a property. This will completely replace the setter with the code specified in the string array.
- Example Usage:
```json
"shapeModifiers":{
    "CopyObjectRequest":{
        "modify":[
            {
                "ContentType":{
                    "injectXmlPropertySetter":[
                        "set { this.Headers.ContentType = value; }"
                    ]
                }
            }
        ]
    }
}
```

### Name: skipSetter
### Type: bool
- Description: This customization hook is used to completely skip generation of the setter for a given member. If this is set to true, no setter will be generated.
- Example Usage:
```json
"shapeModifiers":{
    "WriteGetObjectResponseRequest":{
        "modify":[
            {
                "Metadata" : {
                    "skipSetter" : true
                }
            }
        ]
    }
}
```

### Name: injectXmlMarshallCode
### Type: string[]
- Description: This customization hook is used to inject code when marshalling a member. This can be used for any member that needs to be marshalled, whether it be part of the payload or a header.
- Example Usage:
```json
"shapeModifiers":{
    "AnalyticsConfiguration": {
        "modify": [
            {
                "AnalyticsFilter" :{
                    "injectXmlMarshallCode": ["AnalyticsFilterCustomMarshall(publicRequest, xmlWriter);"]
                }
            }
        ]
    }
}
```

### Name: skipXmlIsSet
### Type: bool
- Description: This customization hook skips generating the `IsSet` method for a given member. This customization hook is only complete for rest-xml protocols. It will skip generating `IsSet` and also skip checking `IsSet` during marshalling. If used for other protocols, it will skip generating `IsSet` in the structure but not in the marshallers. 
- Example Usage:
```json
"shapeModifiers":{
    "PutObjectRequest":{
        "modify":[
            {
                "ContentType": {
                    "skipXmlIsSet" : true
                }
            }
        ]
    }
}
```

### Name: skipPrivateMember
### Type: bool
- Description: This customization hook is used when you want to skip generating the private backing field for a property. This is useful when the property gets its value from another property or custom logic rather than storing its own value in a private field.
- Example Usage:
```json
"shapeModifiers":{
    "PutObjectRequest":{
        "modify":[
            {
                "ContentType": {
                    "skipPrivateMember": true
                }
            }
        ]
    }
}
```

### Name: flattenShapes
### Type: string[]
- Description: The flattenShapes customization hook is used when you want to flatten a member into its parent shape. For example, if shape `foo` has member `bar` and `bar` has members `member1` and `member2`, then `foo` will contain `member1` and `member2`.
- Example Usage:
```json
    "flattenShapes" : {
        "PutBucketNotificationConfigurationRequest" : [
            "NotificationConfiguration"
        ]
    }
```

### Name: excludeShapes
### Type: string[]
- Description: The excludeShapes customization hook is used to exclude shapes from being generated altogether.
- Example Usage:
```json
    "excludeShapes":[
        "NotificationConfiguration",
        "CopyPartResult",
        "CopyObjectResult",
        "MetricsFilter",
        "MetricsAndOperator",
        "AnalyticsFilter",
        "AnalyticsAndOperator",
        "IntelligentTieringFilter",
        "IntelligentTieringAndOperator",
        "InventoryFilter",
        "GlacierJobTier",
        "CompletedMultipartUpload",
        "BucketLoggingStatus",
        "ErrorDocument",
        "IndexDocument",
        "RedirectAllRequestsTo"
    ]
```

### Name: predicateListUnmarshallers
### Type: object[]
- Description: S3 has unique customizations where a filter's members are defined as "predicates". The predicates are unmarshalled and attached to the FilterPredicate property of the filter, which all of the predicates derive from. This customization should not be used for future operations, and is mainly for backwards compatibility purposes.
- Example Usage: 
```json
"shapeModifiers":{
    "MetricsConfiguration":{
        "predicateListUnmarshallers": [
            {
                "MetricsFilter" :{
                    "predicateListUnmarshallerName" : "MetricsPredicateListFilterUnmarshaller",
                    "filterPredicateName": "MetricsFilterPredicate"
                }
            }
        ]
    }
}
```

This would generate an unmarshaller like such (for the above example within the unmarshaller):
```csharp
if (context.TestExpression("Filter", targetDepth))
{
    var predicateList = MetricsPredicateListFilterUnmarshaller.Instance.Unmarshall(context);
    unmarshalledObject.MetricsFilter = new MetricsFilter();
    unmarshalledObject.MetricsFilter.MetricsFilterPredicate = predicateList[0];
    continue;
}
```

### Name: additionalDocumentation
### Type: string[]
- Description: This customization hook is used to add additional documentation to a member.
- Example Usage:
```json
"shapeModifiers":{
    "PutObjectRequest":{
        "modify":[
            {
                "InputStream":{"additionalDocumentation":["<para>Input stream for the request; content for the request will be read from the stream.</para>"]}
            }
        ]
    }
}
```

### Name: unwrapXmlOutput
### Type: bool
- Description: This customization hook is used to unwrap the response, and is only used for XML services. This is used when the output is not wrapped in a top-level output xml element and only includes the member at the root level like GetBucketLocation.
- Example Usage:
```json
    "unwrapXmlOutput":{
        "GetBucketLocationOutput": true
    }
```

### Name: overrideTreatEnumsAsString
### Type: object
- Description: This customization hook is used to override treating enums as string for collections. Collections of enums are treated as collections of strings by default in the generator. By using this customization hook, it will be treated as a collection of the enum instead. Since by default treatEnumsAsString is set to true, this overrides the value to false.
- Example Usage:
```json
    "overrideTreatEnumsAsString":{
        "ObjectAttributesList": false,
        "InventoryOptionalFields": false
    }
```

### Name: inheritAlternateBaseClass
### Type: object
- Description: This customization hook is used to have a class inherit an alternate base class rather than the default `AmazonWebServiceRequest`. Within the `"inheritAlternateBaseClass"` JSON object, specify the class that will inherit the alternate base class, then specify what the base class is under `"alternateBaseClass"`.
- Example Usage:
```json
    "inheritAlternateBaseClass":{
        "PutBucketRequest": {
            "alternateBaseClass" : "PutWithACLRequest"
        }
    }
``` 

### Name: alternateLocationName
### Type: string
- Description: This customization hook is used to specify an alternate location name to use during marshalling instead of the property name. This allows the property to be marshalled using a different name than its modeled name. This is used from the context of a DataTypeSwap, which is a kind of customization hook in itself.
- Example Usage:
```json
"dataTypeSwap":{
    "TopicConfiguration" :{
        "Events" : {
            "Type" : "List<EventType>",
            "Marshaller" : "StringUtils.FromString",
            "Unmarshaller" : "StringUnmarshaller",
            "isFlattened": true,
            "alternateLocationName": "Event"
        }
    }
}
```

### Name: isFlattened
### Type: bool
- Description: This customization hook is used to specify that the member should be flattened. This is used for lists and maps. Using a list as an example, this means that instead of marshalling the member inside of a `<member>` tag, it is marshalled directly on the parent shape. If `Foo` represents the list which has one member `Bar`, `isFlattened` being true means it is marshalled as `<Foo><Bar>value</Bar></Foo>`. 
- Example Usage:
```json
"dataTypeSwap":{
    "TopicConfiguration" :{
        "Events" : {
            "Type" : "List<EventType>",
            "Marshaller" : "StringUtils.FromString",
            "Unmarshaller" : "StringUnmarshaller",
            "isFlattened": true,
            "alternateLocationName": "Event"
        }
    }
}
```

### Name: mergedEnums
### Type: object
- Description: Use this customization hook to specify that an enum should be merged into existing enums instead of being generated separately.
- Example Usage:
```json
    "mergedEnums": {
        "MFADeleteStatus": {
            "mergeInto": "VersionStatus"
        }
    }
```

### Name: skipChecksumDuringMarshalling
### Type: bool
- Description: Use this customization hook to skip setting the checksum during marshalling. If an operation has custom logic for setting checksums, this customization hook can be used. It can also be used to completely skip setting the checksum, although that should rarely be the case.
- Example Usage:
```json
"operationModifiers":{
    "UploadPart": {
        "skipChecksumDuringMarshalling": true
    }
}
```

### Name: excludePaginators
### Type: bool
- Description: Use this customization hook to exclude generation of paginators for a particular operation.
- Example Usage:
```json
"operationModifiers":{
    "ListParts":{
        "excludePaginators":true
    }
}
```

### Name: excludeResultKey
### Type: string[]
- Description: Use this customization hook to exclude the result keys specified in the result_keys in the paginator model.
- Example Usage:
```json
"operationModifiers":{
    "ListVersions":{
        "excludeResultKey":[
            "DeleteMarkers"
        ]
    }
}
```


TODO: 
predicateListUnmarshallers
shapeDocumentation
injectXmlUnmarshallResultCode (done)
InjectXmlIsSetCode (done)
InjectXmlPrivateMemberAssignment (done)
InjectXmlPropertyGetterKey (done)
InjectXmlPropertySetterKey (done)
SkipSetterKey (done)
InjectXmlMarshallCodeKey(done)
SkipXmlIsSetKey (done)
SkipPrivateMemberKey(done)
additionalDocumentation (done)
UnwrapXmlOutput (done)
OverrideTreatEnumsAsString (done)
InheritAlternateBaseClass (done)
AlternateLocationNAme (done)
DataTypeSwapIsFlatteend (done)
MergedEnums (done)
SkipChecksumDuringMarshalling (done)
ExcludePaginators (done)
ExcludeResultKeys (done)
MarshallNameOverrides 
