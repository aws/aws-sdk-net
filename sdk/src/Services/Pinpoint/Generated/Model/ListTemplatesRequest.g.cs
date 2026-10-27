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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Container for the parameters to the ListTemplates operation. Retrieves information
    /// about all the message templates that are associated with your Amazon Pinpoint account.
    /// </summary>
    public partial class ListTemplatesRequest : AmazonPinpointRequest
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string that specifies which page of results to return in a paginated response.
        /// This parameter is not supported for application, campaign, and journey metrics.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of items to include in each page of a paginated response. This
        /// parameter is not supported for application, campaign, and journey metrics.
        /// </para>
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The substring to match in the names of the message templates to include in the results.
        /// If you specify this value, Amazon Pinpoint returns only those templates whose names
        /// begin with the value that you specify.
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The type of message template to include in the results. Valid values are: EMAIL, PUSH,
        /// SMS, and VOICE. To include all types of templates in the results, don't include this
        /// parameter in your request.
        /// </para>
        /// </summary>
        public string TemplateType { get; set; }

        /// <summary>
        /// Checks to see if the TemplateType property is set.
        /// </summary>
        internal bool IsSetTemplateType() => this.TemplateType != null;
    }
}
