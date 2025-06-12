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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Lake Formation configuration of the Data Lake blueprint.
    /// </summary>
    public partial class LakeFormationConfiguration
    {
        private List<string> _locationRegistrationExcludeS3Locations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _locationRegistrationRole;

        /// <summary>
        /// Gets and sets the property LocationRegistrationExcludeS3Locations. 
        /// <para>
        /// Specifies certain Amazon S3 locations if you do not want Amazon DataZone to automatically
        /// register them in hybrid mode. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> LocationRegistrationExcludeS3Locations
        {
            get { return this._locationRegistrationExcludeS3Locations; }
            set { this._locationRegistrationExcludeS3Locations = value; }
        }

        // Check to see if LocationRegistrationExcludeS3Locations property is set
        internal bool IsSetLocationRegistrationExcludeS3Locations()
        {
            return this._locationRegistrationExcludeS3Locations != null && (this._locationRegistrationExcludeS3Locations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LocationRegistrationRole. 
        /// <para>
        /// The role that is used to manage read/write access to the chosen Amazon S3 bucket(s)
        /// for Data Lake using Amazon Web Services Lake Formation hybrid access mode.
        /// </para>
        /// </summary>
        public string LocationRegistrationRole
        {
            get { return this._locationRegistrationRole; }
            set { this._locationRegistrationRole = value; }
        }

        // Check to see if LocationRegistrationRole property is set
        internal bool IsSetLocationRegistrationRole()
        {
            return this._locationRegistrationRole != null;
        }

    }
}