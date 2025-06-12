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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Specifies the configuration for distributing protected query results to multiple
    /// receivers, including S3 and collaboration members.
    /// </summary>
    public partial class ProtectedQueryDistributeOutputConfiguration
    {
        private List<ProtectedQueryDistributeOutputConfigurationLocation> _locations = AWSConfigs.InitializeCollections ? new List<ProtectedQueryDistributeOutputConfigurationLocation>() : null;

        /// <summary>
        /// Gets and sets the property Locations. 
        /// <para>
        ///  A list of locations where you want to distribute the protected query results. Each
        /// location must specify either an S3 destination or a collaboration member destination.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can't specify more than one S3 location.
        /// </para>
        ///  
        /// <para>
        /// You can't specify the query runner's account as a member location.
        /// </para>
        ///  
        /// <para>
        /// You must include either an S3 or member output configuration for each location, but
        /// not both.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<ProtectedQueryDistributeOutputConfigurationLocation> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }

        // Check to see if Locations property is set
        internal bool IsSetLocations()
        {
            return this._locations != null && (this._locations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}