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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the ListPredefinedAttributes operation.
    /// Lists predefined attributes for the specified Amazon Connect instance. A <i>predefined
    /// attribute</i> is made up of a name and a value. You can use predefined attributes
    /// for:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Routing proficiency (for example, agent certification) that has predefined values
    /// (for example, a list of possible certifications). For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/predefined-attributes.html">Create
    /// predefined attributes for routing contacts to agents</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Contact information that varies between transfers or conferences, such as the name
    /// of the business unit handling the contact. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/use-contact-segment-attributes.html">Use
    /// contact segment attributes</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For the predefined attributes per instance quota, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#connect-quotas">Amazon
    /// Connect quotas</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoints</b>: See <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Amazon
    /// Connect endpoints and quotas</a>.
    /// </para>
    /// </summary>
    public partial class ListPredefinedAttributesRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instance ID in the
        /// Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
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

    }
}