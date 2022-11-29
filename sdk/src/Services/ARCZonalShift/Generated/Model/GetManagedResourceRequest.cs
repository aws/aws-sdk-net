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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// Container for the parameters to the GetManagedResource operation.
    /// Get information about a resource that's been registered for zonal shifts with Amazon
    /// Route 53 Application Recovery Controller in this AWS Region. Resources that are registered
    /// for zonal shifts are managed resources in Route 53 ARC.
    /// 
    ///  
    /// <para>
    /// At this time, you can only start a zonal shift for Network Load Balancers and Application
    /// Load Balancers with cross-zone load balancing turned off.
    /// </para>
    /// </summary>
    public partial class GetManagedResourceRequest : AmazonARCZonalShiftRequest
    {
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The identifier for the resource to include in a zonal shift. The identifier is the
        /// Amazon Resource Name (ARN) for the resource.
        /// </para>
        ///  
        /// <para>
        /// At this time, you can only start a zonal shift for Network Load Balancers and Application
        /// Load Balancers with cross-zone load balancing turned off.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=1024)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

    }
}