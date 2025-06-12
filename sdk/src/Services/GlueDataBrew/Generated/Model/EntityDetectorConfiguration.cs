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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Configuration of entity detection for a profile job. When undefined, entity detection
    /// is disabled.
    /// </summary>
    public partial class EntityDetectorConfiguration
    {
        private List<AllowedStatistics> _allowedStatistics = AWSConfigs.InitializeCollections ? new List<AllowedStatistics>() : null;
        private List<string> _entityTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedStatistics. 
        /// <para>
        /// Configuration of statistics that are allowed to be run on columns that contain detected
        /// entities. When undefined, no statistics will be computed on columns that contain detected
        /// entities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<AllowedStatistics> AllowedStatistics
        {
            get { return this._allowedStatistics; }
            set { this._allowedStatistics = value; }
        }

        // Check to see if AllowedStatistics property is set
        internal bool IsSetAllowedStatistics()
        {
            return this._allowedStatistics != null && (this._allowedStatistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EntityTypes. 
        /// <para>
        /// Entity types to detect. Can be any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// USA_SSN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USA_ITIN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USA_PASSPORT_NUMBER
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PHONE_NUMBER
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USA_DRIVING_LICENSE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BANK_ACCOUNT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREDIT_CARD
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IP_ADDRESS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAC_ADDRESS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USA_DEA_NUMBER
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USA_HCPCS_CODE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USA_NATIONAL_PROVIDER_IDENTIFIER
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USA_NATIONAL_DRUG_CODE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USA_HEALTH_INSURANCE_CLAIM_NUMBER
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USA_MEDICARE_BENEFICIARY_IDENTIFIER
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USA_CPT_CODE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PERSON_NAME
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DATE
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The Entity type group USA_ALL is also supported, and includes all of the above entity
        /// types except PERSON_NAME and DATE.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> EntityTypes
        {
            get { return this._entityTypes; }
            set { this._entityTypes = value; }
        }

        // Check to see if EntityTypes property is set
        internal bool IsSetEntityTypes()
        {
            return this._entityTypes != null && (this._entityTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}