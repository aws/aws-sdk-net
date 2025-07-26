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
using System.Xml;
using Amazon.S3.Model.Internal.MarshallTransformations;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for granting information.
    /// 
    ///  
    /// <para>
    /// Buckets that use the bucket owner enforced setting for Object Ownership don't support
    /// target grants. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/enable-server-access-logging.html#grant-log-delivery-permissions-general">Permissions
    /// server access log delivery</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class S3Grant
    {
        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(memberName);
            {
                if (Grantee != null)
                {
                    xmlWriter.WriteStartElement("xsi","Grantee", "http://www.w3.org/2001/XMLSchema-instance");
                    if (Grantee.IsSetType())
                    {
                        xmlWriter.WriteAttributeString("xsi", "type",
                                                       "http://www.w3.org/2001/XMLSchema-instance",
                                                       Grantee.Type.ToString());
                    }
                    if (Grantee.IsSetDisplayName())
                    {
                        xmlWriter.WriteElementString("DisplayName",
                                                     S3Transforms.ToXmlStringValue(
                                                         Grantee.DisplayName));
                    }
                    if (Grantee.IsSetEmailAddress())
                    {
                        xmlWriter.WriteElementString("EmailAddress",
                                                     S3Transforms.ToXmlStringValue(
                                                         Grantee.EmailAddress));
                    }
                    if (Grantee.IsSetCanonicalUser())
                    {
                        xmlWriter.WriteElementString("ID",
                                                     S3Transforms.ToXmlStringValue(
                                                         Grantee.CanonicalUser));
                    }
                    if (Grantee.IsSetURI())
                    {
                        xmlWriter.WriteElementString("URI",
                                                     S3Transforms.ToXmlStringValue(
                                                         Grantee.URI));
                    }
                    xmlWriter.WriteEndElement();
                }

                if (IsSetPermission())
                {
                    xmlWriter.WriteElementString("Permission",
                                                 S3Transforms.ToXmlStringValue(
                                                     Permission));
                }
            }
            xmlWriter.WriteEndElement();
        }
    }
}
