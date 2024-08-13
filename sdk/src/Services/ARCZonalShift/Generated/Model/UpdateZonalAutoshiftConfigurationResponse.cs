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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// This is the response object from the UpdateZonalAutoshiftConfiguration operation.
    /// </summary>
    public partial class UpdateZonalAutoshiftConfigurationResponse : AmazonWebServiceResponse
    {
        private string _resourceIdentifier;
        private ZonalAutoshiftStatus _zonalAutoshiftStatus;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The identifier for the resource that you updated the zonal autoshift configuration
        /// for. The identifier is the Amazon Resource Name (ARN) for the resource.
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

        /// <summary>
        /// Gets and sets the property ZonalAutoshiftStatus. 
        /// <para>
        /// The updated zonal autoshift status for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ZonalAutoshiftStatus ZonalAutoshiftStatus
        {
            get { return this._zonalAutoshiftStatus; }
            set { this._zonalAutoshiftStatus = value; }
        }

        // Check to see if ZonalAutoshiftStatus property is set
        internal bool IsSetZonalAutoshiftStatus()
        {
            return this._zonalAutoshiftStatus != null;
        }

    }
}