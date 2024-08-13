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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
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
namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// The result of a successful Resource request, with status for an individual resource.
    /// </summary>
    public partial class ResourceResult
    {
        private string _componentId;
        private DateTime? _lastCheckedTimestamp;
        private Readiness _readiness;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// The component id of the resource.
        /// </para>
        /// </summary>
        public string ComponentId
        {
            get { return this._componentId; }
            set { this._componentId = value; }
        }

        // Check to see if ComponentId property is set
        internal bool IsSetComponentId()
        {
            return this._componentId != null;
        }

        /// <summary>
        /// Gets and sets the property LastCheckedTimestamp. 
        /// <para>
        /// The time (UTC) that the resource was last checked for readiness, in ISO-8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastCheckedTimestamp
        {
            get { return this._lastCheckedTimestamp; }
            set { this._lastCheckedTimestamp = value; }
        }

        // Check to see if LastCheckedTimestamp property is set
        internal bool IsSetLastCheckedTimestamp()
        {
            return this._lastCheckedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Readiness. 
        /// <para>
        /// The readiness of a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Readiness Readiness
        {
            get { return this._readiness; }
            set { this._readiness = value; }
        }

        // Check to see if Readiness property is set
        internal bool IsSetReadiness()
        {
            return this._readiness != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}