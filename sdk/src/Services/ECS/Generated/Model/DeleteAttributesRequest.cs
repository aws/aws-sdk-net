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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAttributes operation.
    /// Deletes one or more custom attributes from an Amazon ECS resource.
    /// </summary>
    public partial class DeleteAttributesRequest : AmazonECSRequest
    {
        private List<Attribute> _attributes = new List<Attribute>();
        private string _cluster;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes to delete from your resource. You can specify up to 10 attributes per
        /// request. For custom attributes, specify the attribute name and target ID, but do not
        /// specify the value. If you specify the target ID using the short form, you must also
        /// specify the target type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Attribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that contains the
        /// resource to delete attributes. If you do not specify a cluster, the default cluster
        /// is assumed.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

    }
}