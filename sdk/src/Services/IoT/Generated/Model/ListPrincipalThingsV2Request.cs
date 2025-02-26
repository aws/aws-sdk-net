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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListPrincipalThingsV2 operation.
    /// Lists the things associated with the specified principal. A principal can be an X.509
    /// certificate or an Amazon Cognito ID.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListPrincipalThings</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class ListPrincipalThingsV2Request : AmazonIoTRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _principal;
        private ThingPrincipalType _thingPrincipalType;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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
        /// To retrieve the next set of results, the <c>nextToken</c> value from a previous response;
        /// otherwise <b>null</b> to receive the first set of results.
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
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal. A principal can be an X.509 certificate or an Amazon Cognito ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

        /// <summary>
        /// Gets and sets the property ThingPrincipalType. 
        /// <para>
        /// The type of the relation you want to filter in the response. If no value is provided
        /// in this field, the response will list all things, including both the <c>EXCLUSIVE_THING</c>
        /// and <c>NON_EXCLUSIVE_THING</c> attachment types.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EXCLUSIVE_THING</c> - Attaches the specified principal to the specified thing,
        /// exclusively. The thing will be the only thing that’s attached to the principal.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>NON_EXCLUSIVE_THING</c> - Attaches the specified principal to the specified thing.
        /// Multiple things can be attached to the principal.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ThingPrincipalType ThingPrincipalType
        {
            get { return this._thingPrincipalType; }
            set { this._thingPrincipalType = value; }
        }

        // Check to see if ThingPrincipalType property is set
        internal bool IsSetThingPrincipalType()
        {
            return this._thingPrincipalType != null;
        }

    }
}