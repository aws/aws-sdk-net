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

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReadinessCheck operation.
    /// Creates a new Readiness Check.
    /// </summary>
    public partial class CreateReadinessCheckRequest : AmazonRoute53RecoveryReadinessRequest
    {
        private string _readinessCheckName;
        private string _resourceSetName;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ReadinessCheckName. The name of the ReadinessCheck to create
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReadinessCheckName
        {
            get { return this._readinessCheckName; }
            set { this._readinessCheckName = value; }
        }

        // Check to see if ReadinessCheckName property is set
        internal bool IsSetReadinessCheckName()
        {
            return this._readinessCheckName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSetName. The name of the ResourceSet to check
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceSetName
        {
            get { return this._resourceSetName; }
            set { this._resourceSetName = value; }
        }

        // Check to see if ResourceSetName property is set
        internal bool IsSetResourceSetName()
        {
            return this._resourceSetName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}