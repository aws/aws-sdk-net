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

/*
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// The following elements are returned by the service.
    /// </summary>
    public partial class ListEmailTemplatesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<EmailTemplateMetadata> _templatesMetadata = AWSConfigs.InitializeCollections ? new List<EmailTemplateMetadata>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token indicating that there are additional email templates available to be listed.
        /// Pass this token to a subsequent <c>ListEmailTemplates</c> call to retrieve the next
        /// 10 email templates.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TemplatesMetadata. 
        /// <para>
        /// An array the contains the name and creation time stamp for each template in your Amazon
        /// SES account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EmailTemplateMetadata> TemplatesMetadata
        {
            get { return this._templatesMetadata; }
            set { this._templatesMetadata = value; }
        }

        // Check to see if TemplatesMetadata property is set
        internal bool IsSetTemplatesMetadata()
        {
            return this._templatesMetadata != null && (this._templatesMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}