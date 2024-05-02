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
    /// Container for the parameters to the ListAttachedPolicies operation.
    /// Lists the policies attached to the specified thing group.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAttachedPolicies</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class ListAttachedPoliciesRequest : AmazonIoTRequest
    {
        private string _marker;
        private int? _pageSize;
        private bool? _recursive;
        private string _target;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The token to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of results to be returned per request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int? PageSize
        {
            get { return this._pageSize; }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recursive. 
        /// <para>
        /// When true, recursively list attached policies.
        /// </para>
        /// </summary>
        public bool? Recursive
        {
            get { return this._recursive; }
            set { this._recursive = value; }
        }

        // Check to see if Recursive property is set
        internal bool IsSetRecursive()
        {
            return this._recursive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The group or principal for which the policies will be listed. Valid principals are
        /// CertificateArn (arn:aws:iot:<i>region</i>:<i>accountId</i>:cert/<i>certificateId</i>),
        /// thingGroupArn (arn:aws:iot:<i>region</i>:<i>accountId</i>:thinggroup/<i>groupName</i>)
        /// and CognitoId (<i>region</i>:<i>id</i>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}