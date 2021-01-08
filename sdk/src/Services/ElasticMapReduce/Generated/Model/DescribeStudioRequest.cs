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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStudio operation.
    /// <note> 
    /// <para>
    /// The Amazon EMR Studio APIs are in preview release for Amazon EMR and are subject to
    /// change.
    /// </para>
    ///  </note> 
    /// <para>
    /// Returns details for the specified Amazon EMR Studio including ID, Name, VPC, Studio
    /// access URL, and so on.
    /// </para>
    /// </summary>
    public partial class DescribeStudioRequest : AmazonElasticMapReduceRequest
    {
        private string _studioId;

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The Amazon EMR Studio ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string StudioId
        {
            get { return this._studioId; }
            set { this._studioId = value; }
        }

        // Check to see if StudioId property is set
        internal bool IsSetStudioId()
        {
            return this._studioId != null;
        }

    }
}