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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DeleteFleets operation.
    /// </summary>
    public partial class DeleteFleetsResponse : AmazonWebServiceResponse
    {
        private List<DeleteFleetSuccessItem> _successfulFleetDeletions = AWSConfigs.InitializeCollections ? new List<DeleteFleetSuccessItem>() : null;
        private List<DeleteFleetErrorItem> _unsuccessfulFleetDeletions = AWSConfigs.InitializeCollections ? new List<DeleteFleetErrorItem>() : null;

        /// <summary>
        /// Gets and sets the property SuccessfulFleetDeletions. 
        /// <para>
        /// Information about the EC2 Fleets that are successfully deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeleteFleetSuccessItem> SuccessfulFleetDeletions
        {
            get { return this._successfulFleetDeletions; }
            set { this._successfulFleetDeletions = value; }
        }

        // Check to see if SuccessfulFleetDeletions property is set
        internal bool IsSetSuccessfulFleetDeletions()
        {
            return this._successfulFleetDeletions != null && (this._successfulFleetDeletions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnsuccessfulFleetDeletions. 
        /// <para>
        /// Information about the EC2 Fleets that are not successfully deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeleteFleetErrorItem> UnsuccessfulFleetDeletions
        {
            get { return this._unsuccessfulFleetDeletions; }
            set { this._unsuccessfulFleetDeletions = value; }
        }

        // Check to see if UnsuccessfulFleetDeletions property is set
        internal bool IsSetUnsuccessfulFleetDeletions()
        {
            return this._unsuccessfulFleetDeletions != null && (this._unsuccessfulFleetDeletions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}