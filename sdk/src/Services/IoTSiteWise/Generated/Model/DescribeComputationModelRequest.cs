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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeComputationModel operation.
    /// Retrieves information about a computation model.
    /// </summary>
    public partial class DescribeComputationModelRequest : AmazonIoTSiteWiseRequest
    {
        private string _computationModelId;
        private string _computationModelVersion;

        /// <summary>
        /// Gets and sets the property ComputationModelId. 
        /// <para>
        /// The ID of the computation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ComputationModelId
        {
            get { return this._computationModelId; }
            set { this._computationModelId = value; }
        }

        // Check to see if ComputationModelId property is set
        internal bool IsSetComputationModelId()
        {
            return this._computationModelId != null;
        }

        /// <summary>
        /// Gets and sets the property ComputationModelVersion. 
        /// <para>
        /// The version of the computation model.
        /// </para>
        /// </summary>
        public string ComputationModelVersion
        {
            get { return this._computationModelVersion; }
            set { this._computationModelVersion = value; }
        }

        // Check to see if ComputationModelVersion property is set
        internal bool IsSetComputationModelVersion()
        {
            return this._computationModelVersion != null;
        }

    }
}