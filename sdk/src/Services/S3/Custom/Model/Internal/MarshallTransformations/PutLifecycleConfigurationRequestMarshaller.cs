/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Custom marshaller for PutLifecycleConfigurationRequest with custom methods
    /// </summary>
    public partial class PutLifecycleConfigurationRequestMarshaller : IMarshaller<IRequest, PutLifecycleConfigurationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Custom marshall for lifecycle rule filter
        /// </summary>
        /// <param name="publicRequestConfigurationRulesValue"></param>
        /// <param name="xmlWriter"></param>
        public void FilterCustomMarshall(LifecycleRule publicRequestConfigurationRulesValue, XmlWriter xmlWriter)
        {
            if (publicRequestConfigurationRulesValue.Filter != null)
            {
                xmlWriter.WriteStartElement("Filter");
                if (publicRequestConfigurationRulesValue.Filter.LifecycleFilterPredicate != null)
                {
                    publicRequestConfigurationRulesValue.Filter.LifecycleFilterPredicate.Accept(new LifecycleFilterPredicateMarshallVisitor(xmlWriter));
                    xmlWriter.WriteEndElement();
                    // only return if there is a predicate so we don't write it twice
                    return;
                }
                if (publicRequestConfigurationRulesValue.Filter.And != null)
                {
                    xmlWriter.WriteStartElement("And");
                    if (publicRequestConfigurationRulesValue.Filter.And.IsSetObjectSizeGreaterThan())
                        xmlWriter.WriteElementString("ObjectSizeGreaterThan", StringUtils.FromLong(publicRequestConfigurationRulesValue.Filter.And.ObjectSizeGreaterThan.Value));
                    if (publicRequestConfigurationRulesValue.Filter.And.IsSetObjectSizeLessThan())
                        xmlWriter.WriteElementString("ObjectSizeLessThan", StringUtils.FromLong(publicRequestConfigurationRulesValue.Filter.And.ObjectSizeLessThan.Value));
                    if (publicRequestConfigurationRulesValue.Filter.And.IsSetPrefix())
                        xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.And.Prefix));
                    var publicRequestConfigurationRulesValueFilterAndTags = publicRequestConfigurationRulesValue.Filter.And.Tags;
                    if (publicRequestConfigurationRulesValueFilterAndTags != null && (publicRequestConfigurationRulesValueFilterAndTags.Count > 0 || !AWSConfigs.InitializeCollections))
                    {
                        foreach (var publicRequestConfigurationRulesValueFilterAndTagsValue in publicRequestConfigurationRulesValueFilterAndTags)
                        {
                            if (publicRequestConfigurationRulesValueFilterAndTagsValue != null)
                            {
                                xmlWriter.WriteStartElement("Tag");
                                if (publicRequestConfigurationRulesValueFilterAndTagsValue.IsSetKey())
                                    xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestConfigurationRulesValueFilterAndTagsValue.Key));
                                if (publicRequestConfigurationRulesValueFilterAndTagsValue.IsSetValue())
                                    xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestConfigurationRulesValueFilterAndTagsValue.Value));
                                xmlWriter.WriteEndElement();
                            }
                        }
                    }
                    xmlWriter.WriteEndElement();
                }
                if (publicRequestConfigurationRulesValue.Filter.IsSetObjectSizeGreaterThan())
                    xmlWriter.WriteElementString("ObjectSizeGreaterThan", StringUtils.FromLong(publicRequestConfigurationRulesValue.Filter.ObjectSizeGreaterThan.Value));
                if (publicRequestConfigurationRulesValue.Filter.IsSetObjectSizeLessThan())
                    xmlWriter.WriteElementString("ObjectSizeLessThan", StringUtils.FromLong(publicRequestConfigurationRulesValue.Filter.ObjectSizeLessThan.Value));
                if (publicRequestConfigurationRulesValue.Filter.IsSetPrefix())
                    xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Prefix));
                if (publicRequestConfigurationRulesValue.Filter.Tag != null)
                {
                    xmlWriter.WriteStartElement("Tag");
                    if (publicRequestConfigurationRulesValue.Filter.Tag.IsSetKey())
                        xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Tag.Key));
                    if (publicRequestConfigurationRulesValue.Filter.Tag.IsSetValue())
                        xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Tag.Value));
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
            }
        }
        void CustomStatusMarshalling(XmlWriter writer, LifecycleRule rule)
        {
            if (rule.IsSetStatus())
            {
                writer.WriteElementString("Status", S3Transforms.ToXmlStringValue(rule.Status));
            }
            else
            {
                writer.WriteElementString("Status", "Disabled");
            } 
        }
    }
}
