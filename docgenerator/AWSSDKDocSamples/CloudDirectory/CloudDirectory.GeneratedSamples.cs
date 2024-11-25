using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.CloudDirectory;
using Amazon.CloudDirectory.Model;

namespace AWSSDKDocSamples.Amazon.CloudDirectory.Generated
{
    class CloudDirectorySamples : ISample
    {
        public void CloudDirectoryAddFacetToObject()
        {
            #region to-add-a-facet-to-an-object-1507568792747

            var client = new AmazonCloudDirectoryClient();
            var response = client.AddFacetToObject(new AddFacetToObjectRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                ObjectAttributeList = new List<AttributeKeyAndValue> {
                    
                },
                ObjectReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWmspn1fxfQmSQaaVKSbvEiQ" },
                SchemaFacet = new SchemaFacet {
                    FacetName = "node1",
                    SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY/schema/org/1"
                }
            });


            #endregion
        }

        public void CloudDirectoryApplySchema()
        {
            #region to-apply-a-schema-1507061899015

            var client = new AmazonCloudDirectoryClient();
            var response = client.ApplySchema(new ApplySchemaRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AfMr4qym1kZTvwqOafAYfqI",
                PublishedSchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:schema/published/org/1"
            });

            string appliedSchemaArn = response.AppliedSchemaArn;
            string directoryArn = response.DirectoryArn;

            #endregion
        }

        public void CloudDirectoryAttachObject()
        {
            #region to-attach-an-object-1507060976164

            var client = new AmazonCloudDirectoryClient();
            var response = client.AttachObject(new AttachObjectRequest 
            {
                ChildReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWSvfuEnDqTdmeCuTs6YBNUA" },
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                LinkName = "link2",
                ParentReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWcU7IARvOTeaR09zme1sVsw" }
            });

            string attachedObjectIdentifier = response.AttachedObjectIdentifier;

            #endregion
        }

        public void CloudDirectoryAttachPolicy()
        {
            #region to-attach-a-policy-to-an-object-1508268194724

            var client = new AmazonCloudDirectoryClient();
            var response = client.AttachPolicy(new AttachPolicyRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                ObjectReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWQoovm1s3Ts2v0NKrzdVnPw" },
                PolicyReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWgcBsTVmcQEWs6jlygfhuew" }
            });


            #endregion
        }

        public void CloudDirectoryAttachToIndex()
        {
            #region to-attach-a-index-to-an-object-1506532855758

            var client = new AmazonCloudDirectoryClient();
            var response = client.AttachToIndex(new AttachToIndexRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                IndexReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TW45F26R1HTY2z-stwKBte_Q" },
                TargetReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWcU7IARvOTeaR09zme1sVsw" }
            });

            string attachedObjectIdentifier = response.AttachedObjectIdentifier;

            #endregion
        }

        public void CloudDirectoryAttachTypedLink()
        {
            #region to-attach-a-typed-link-to-an-object-1506559900588

            var client = new AmazonCloudDirectoryClient();
            var response = client.AttachTypedLink(new AttachTypedLinkRequest 
            {
                Attributes = new List<AttributeNameAndValue> {
                    new AttributeNameAndValue {
                        AttributeName = "22",
                        Value = new TypedAttributeValue { BinaryValue = new MemoryStream(c3Ry) }
                    }
                },
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                SourceObjectReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWSvfuEnDqTdmeCuTs6YBNUA" },
                TargetObjectReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWcU7IARvOTeaR09zme1sVsw" },
                TypedLinkFacet = new TypedLinkSchemaAndFacetName {
                    SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY/schema/org/1",
                    TypedLinkName = "exampletypedlink8"
                }
            });

            TypedLinkSpecifier typedLinkSpecifier = response.TypedLinkSpecifier;

            #endregion
        }

        public void CloudDirectoryBatchRead()
        {
            #region to-run-a-batch-read-command-1506123433380

            var client = new AmazonCloudDirectoryClient();
            var response = client.BatchRead(new BatchReadRequest 
            {
                ConsistencyLevel = "EVENTUAL",
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                Operations = new List<BatchReadOperation> {
                    
                }
            });

            List<BatchReadOperationResponse> responses = response.Responses;

            #endregion
        }

        public void CloudDirectoryBatchWrite()
        {
            #region to-run-a-batch-write-command-1506122878964

            var client = new AmazonCloudDirectoryClient();
            var response = client.BatchWrite(new BatchWriteRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                Operations = new List<BatchWriteOperation> {
                    
                }
            });

            List<BatchWriteOperationResponse> responses = response.Responses;

            #endregion
        }

        public void CloudDirectoryCreateDirectory()
        {
            #region to-create-a-new-cloud-directory-1506119878996

            var client = new AmazonCloudDirectoryClient();
            var response = client.CreateDirectory(new CreateDirectoryRequest 
            {
                Name = "ExampleCD",
                SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:schema/published/person/1"
            });

            string appliedSchemaArn = response.AppliedSchemaArn;
            string directoryArn = response.DirectoryArn;
            string name = response.Name;
            string objectIdentifier = response.ObjectIdentifier;

            #endregion
        }

        public void CloudDirectoryCreateFacet()
        {
            #region to-create-a-facet-1506112442334

            var client = new AmazonCloudDirectoryClient();
            var response = client.CreateFacet(new CreateFacetRequest 
            {
                Name = "node1",
                ObjectType = "NODE",
                SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY/schema/org/1"
            });


            #endregion
        }

        public void CloudDirectoryCreateIndex()
        {
            #region to-create-an-index-1505339563796

            var client = new AmazonCloudDirectoryClient();
            var response = client.CreateIndex(new CreateIndexRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AXQXDXvdgkOWktRXV4HnRa8",
                IsUnique = true,
                LinkName = "Examplelink",
                OrderedIndexedAttributeList = new List<AttributeKey> {
                    
                },
                ParentReference = new ObjectReference {  }
            });

            string objectIdentifier = response.ObjectIdentifier;

            #endregion
        }

        public void CloudDirectoryCreateObject()
        {
            #region to-create-an-object-1494010287120

            var client = new AmazonCloudDirectoryClient();
            var response = client.CreateObject(new CreateObjectRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AXQXDXvdgkOWktRXV4HnRa8",
                SchemaFacets = new List<SchemaFacet> {
                    new SchemaFacet {
                        FacetName = "Organization_Person",
                        SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AXQXDXvdgkOWktRXV4HnRa8/schema/ExampleOrgPersonSchema/1"
                    }
                }
            });

            string objectIdentifier = response.ObjectIdentifier;

            #endregion
        }

        public void CloudDirectoryCreateSchema()
        {
            #region to-create-a-schema-1506530911949

            var client = new AmazonCloudDirectoryClient();
            var response = client.CreateSchema(new CreateSchemaRequest 
            {
                Name = "Customers"
            });

            string schemaArn = response.SchemaArn;

            #endregion
        }

        public void CloudDirectoryCreateTypedLinkFacet()
        {
            #region to-create-a-typed-link-facet-1506127699199

            var client = new AmazonCloudDirectoryClient();
            var response = client.CreateTypedLinkFacet(new CreateTypedLinkFacetRequest 
            {
                Facet = new TypedLinkFacet {
                    Attributes = new List<TypedLinkAttributeDefinition> {
                        new TypedLinkAttributeDefinition {
                            Name = "1",
                            RequiredBehavior = "REQUIRED_ALWAYS",
                            Type = "BINARY"
                        }
                    },
                    IdentityAttributeOrder = new List<string> {
                        "1"
                    },
                    Name = "FacetExample"
                },
                SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:schema/development/typedlinkschema"
            });


            #endregion
        }

        public void CloudDirectoryDeleteDirectory()
        {
            #region to-delete-a-directory-1507570867859

            var client = new AmazonCloudDirectoryClient();
            var response = client.DeleteDirectory(new DeleteDirectoryRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AXQXDXvdgkOWktRXV4HnRa8"
            });

            string directoryArn = response.DirectoryArn;

            #endregion
        }

        public void CloudDirectoryDeleteFacet()
        {
            #region to-delete-a-facet-1507573383449

            var client = new AmazonCloudDirectoryClient();
            var response = client.DeleteFacet(new DeleteFacetRequest 
            {
                Name = "Organization",
                SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:schema/development/exampleorgtest"
            });


            #endregion
        }

        public void CloudDirectoryDeleteObject()
        {
            #region to-delete-an-object-1507574607158

            var client = new AmazonCloudDirectoryClient();
            var response = client.DeleteObject(new DeleteObjectRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AfMr4qym1kZTvwqOafAYfqI",
                ObjectReference = new ObjectReference { Selector = "$AQHzK-KsptZGU78KjmnwGH6i8H-voMZDSNCqfx-fRUcBFg" }
            });


            #endregion
        }

        public void CloudDirectoryDeleteSchema()
        {
            #region to-delete-a-schema-1507575230059

            var client = new AmazonCloudDirectoryClient();
            var response = client.DeleteSchema(new DeleteSchemaRequest 
            {
                SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:schema/development/exampleorgtest"
            });

            string schemaArn = response.SchemaArn;

            #endregion
        }

        public void CloudDirectoryDeleteTypedLinkFacet()
        {
            #region to-delete-a-typed-link-facet-1507576290714

            var client = new AmazonCloudDirectoryClient();
            var response = client.DeleteTypedLinkFacet(new DeleteTypedLinkFacetRequest 
            {
                Name = "ExampleFacet",
                SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:schema/development/typedlinkschematest"
            });


            #endregion
        }

        public void CloudDirectoryDetachFromIndex()
        {
            #region to-detach-an-object-from-an-index-1507579662964

            var client = new AmazonCloudDirectoryClient();
            var response = client.DetachFromIndex(new DetachFromIndexRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                IndexReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TW45F26R1HTY2z-stwKBte_Q" },
                TargetReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWcU7IARvOTeaR09zme1sVsw" }
            });

            string detachedObjectIdentifier = response.DetachedObjectIdentifier;

            #endregion
        }

        public void CloudDirectoryDetachObject()
        {
            #region to-detach-an-object-from-its-parent-object-1508196401149

            var client = new AmazonCloudDirectoryClient();
            var response = client.DetachObject(new DetachObjectRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                LinkName = "link2",
                ParentReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWcU7IARvOTeaR09zme1sVsw" }
            });

            string detachedObjectIdentifier = response.DetachedObjectIdentifier;

            #endregion
        }

        public void CloudDirectoryDetachPolicy()
        {
            #region to-detach-a-policy-from-an-object-1508268395318

            var client = new AmazonCloudDirectoryClient();
            var response = client.DetachPolicy(new DetachPolicyRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                ObjectReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWQoovm1s3Ts2v0NKrzdVnPw" },
                PolicyReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWgcBsTVmcQEWs6jlygfhuew" }
            });


            #endregion
        }

        public void CloudDirectoryDetachTypedLink()
        {
            #region to-detach-a-typed-link-from-an-object-1506540145856

            var client = new AmazonCloudDirectoryClient();
            var response = client.DetachTypedLink(new DetachTypedLinkRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                TypedLinkSpecifier = new TypedLinkSpecifier {
                    IdentityAttributeValues = new List<AttributeNameAndValue> {
                        new AttributeNameAndValue {
                            AttributeName = "22",
                            Value = new TypedAttributeValue { BinaryValue = new MemoryStream(c3Ry) }
                        }
                    },
                    SourceObjectReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWSvfuEnDqTdmeCuTs6YBNUA" },
                    TargetObjectReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWcU7IARvOTeaR09zme1sVsw" },
                    TypedLinkFacet = new TypedLinkSchemaAndFacetName {
                        SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY/schema/org/1",
                        TypedLinkName = "exampletypedlink8"
                    }
                }
            });


            #endregion
        }

        public void CloudDirectoryDisableDirectory()
        {
            #region to-disable-a-directory-1507253386265

            var client = new AmazonCloudDirectoryClient();
            var response = client.DisableDirectory(new DisableDirectoryRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AXQXDXvdgkOWktRXV4HnRa8"
            });

            string directoryArn = response.DirectoryArn;

            #endregion
        }

        public void CloudDirectoryEnableDirectory()
        {
            #region to-enable-a-disabled-directory-1507253506378

            var client = new AmazonCloudDirectoryClient();
            var response = client.EnableDirectory(new EnableDirectoryRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AXQXDXvdgkOWktRXV4HnRa8"
            });

            string directoryArn = response.DirectoryArn;

            #endregion
        }

        public void CloudDirectoryGetDirectory()
        {
            #region to-get-information-about-a-directory-1507235667410

            var client = new AmazonCloudDirectoryClient();
            var response = client.GetDirectory(new GetDirectoryRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY"
            });

            Directory directory = response.Directory;

            #endregion
        }

        public void CloudDirectoryGetFacet()
        {
            #region to-get-information-about-a-facet-1507234748374

            var client = new AmazonCloudDirectoryClient();
            var response = client.GetFacet(new GetFacetRequest 
            {
                Name = "node2",
                SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY/schema/org/1"
            });

            Facet facet = response.Facet;

            #endregion
        }

        public void CloudDirectoryGetObjectInformation()
        {
            #region to-get-information-about-an-object-1507228370573

            var client = new AmazonCloudDirectoryClient();
            var response = client.GetObjectInformation(new GetObjectInformationRequest 
            {
                ConsistencyLevel = "SERIALIZABLE",
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                ObjectReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWmspn1fxfQmSQaaVKSbvEiQ" }
            });

            string objectIdentifier = response.ObjectIdentifier;
            List<SchemaFacet> schemaFacets = response.SchemaFacets;

            #endregion
        }

        public void CloudDirectoryGetSchemaAsJson()
        {
            #region to-get-schema-information-and-display-it-in-json-format-1507249604181

            var client = new AmazonCloudDirectoryClient();
            var response = client.GetSchemaAsJson(new GetSchemaAsJsonRequest 
            {
                SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY/schema/org/1"
            });

            string document = response.Document;
            string name = response.Name;

            #endregion
        }

        public void CloudDirectoryGetTypedLinkFacetInformation()
        {
            #region to-get-information-about-a-typed-link-facet-1507251423121

            var client = new AmazonCloudDirectoryClient();
            var response = client.GetTypedLinkFacetInformation(new GetTypedLinkFacetInformationRequest 
            {
                Name = "exampletypedlink8",
                SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY/schema/org/1"
            });

            List<string> identityAttributeOrder = response.IdentityAttributeOrder;

            #endregion
        }

        public void CloudDirectoryListAppliedSchemaArns()
        {
            #region to-list-applied-schema-arns-for-a-specified-directory-1508194900072

            var client = new AmazonCloudDirectoryClient();
            var response = client.ListAppliedSchemaArns(new ListAppliedSchemaArnsRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY"
            });

            List<string> schemaArns = response.SchemaArns;

            #endregion
        }

        public void CloudDirectoryListAttachedIndices()
        {
            #region to-list-the-indices-attached-to-an-object-1507579868633

            var client = new AmazonCloudDirectoryClient();
            var response = client.ListAttachedIndices(new ListAttachedIndicesRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                TargetReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWcU7IARvOTeaR09zme1sVsw" }
            });

            List<IndexAttachment> indexAttachments = response.IndexAttachments;

            #endregion
        }

        public void CloudDirectoryListDevelopmentSchemaArns()
        {
            #region to-list-the-development-schema-arns-1508262502911

            var client = new AmazonCloudDirectoryClient();
            var response = client.ListDevelopmentSchemaArns(new ListDevelopmentSchemaArnsRequest 
            {
            });

            List<string> schemaArns = response.SchemaArns;

            #endregion
        }

        public void CloudDirectoryListDirectories()
        {
            #region to-list-all-directories-in-your-aws-account-1508262706411

            var client = new AmazonCloudDirectoryClient();
            var response = client.ListDirectories(new ListDirectoriesRequest 
            {
            });

            List<Directory> directories = response.Directories;

            #endregion
        }

        public void CloudDirectoryListFacetAttributes()
        {
            #region to-list-facet-attributes-1508275015421

            var client = new AmazonCloudDirectoryClient();
            var response = client.ListFacetAttributes(new ListFacetAttributesRequest 
            {
                Name = "Organization",
                SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY/schema/org/1"
            });

            List<FacetAttribute> attributes = response.Attributes;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudDirectoryListFacetNames()
        {
            #region to-list-facet-names-1508275974689

            var client = new AmazonCloudDirectoryClient();
            var response = client.ListFacetNames(new ListFacetNamesRequest 
            {
                SchemaArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY/schema/org/1"
            });

            List<string> facetNames = response.FacetNames;

            #endregion
        }

        public void CloudDirectoryListIncomingTypedLinks()
        {
            #region to-list-incoming-typed-links-1508276145750

            var client = new AmazonCloudDirectoryClient();
            var response = client.ListIncomingTypedLinks(new ListIncomingTypedLinksRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                ObjectReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWcU7IARvOTeaR09zme1sVsw" }
            });

            List<TypedLinkSpecifier> linkSpecifiers = response.LinkSpecifiers;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudDirectoryListIndex()
        {
            #region to-list-an-index-1508281185950

            var client = new AmazonCloudDirectoryClient();
            var response = client.ListIndex(new ListIndexRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                IndexReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TW45F26R1HTY2z-stwKBte_Q" }
            });

            List<IndexAttachment> indexAttachments = response.IndexAttachments;

            #endregion
        }

        public void CloudDirectoryListObjectAttributes()
        {
            #region to-list-object-attributes-1508281422770

            var client = new AmazonCloudDirectoryClient();
            var response = client.ListObjectAttributes(new ListObjectAttributesRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                ObjectReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TW45F26R1HTY2z-stwKBte_Q" }
            });

            List<AttributeKeyAndValue> attributes = response.Attributes;

            #endregion
        }

        public void CloudDirectoryListObjectChildren()
        {
            #region to-list-an-objects-children-1508281694794

            var client = new AmazonCloudDirectoryClient();
            var response = client.ListObjectChildren(new ListObjectChildrenRequest 
            {
                DirectoryArn = "arn:aws:clouddirectory:us-west-2:45132example:directory/AYb8AOV81kHNgdj8mAO3dNY",
                ObjectReference = new ObjectReference { Selector = "$AQGG_ADlfNZBzYHY_JgDt3TWcU7IARvOTeaR09zme1sVsw" }
            });

            Dictionary<string, string> children = response.Children;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}