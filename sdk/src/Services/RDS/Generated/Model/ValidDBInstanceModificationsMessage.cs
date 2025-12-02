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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Information about valid modifications that you can make to your DB instance. Contains
    /// the result of a successful call to the <c>DescribeValidDBInstanceModifications</c>
    /// action. You can use this information when you call <c>ModifyDBInstance</c>.
    /// </summary>
    public partial class ValidDBInstanceModificationsMessage
    {
        private ValidAdditionalStorageOptions _additionalStorage;
        private List<ValidStorageOptions> _storage = AWSConfigs.InitializeCollections ? new List<ValidStorageOptions>() : null;
        private bool? _supportsDedicatedLogVolume;
        private List<AvailableProcessorFeature> _validProcessorFeatures = AWSConfigs.InitializeCollections ? new List<AvailableProcessorFeature>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalStorage. 
        /// <para>
        /// The valid additional storage options for the DB instance.
        /// </para>
        /// </summary>
        public ValidAdditionalStorageOptions AdditionalStorage
        {
            get { return this._additionalStorage; }
            set { this._additionalStorage = value; }
        }

        // Check to see if AdditionalStorage property is set
        internal bool IsSetAdditionalStorage()
        {
            return this._additionalStorage != null;
        }

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// Valid storage options for your DB instance.
        /// </para>
        /// </summary>
        public List<ValidStorageOptions> Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this._storage != null && (this._storage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportsDedicatedLogVolume. 
        /// <para>
        /// Indicates whether a DB instance supports using a dedicated log volume (DLV).
        /// </para>
        /// </summary>
        public bool SupportsDedicatedLogVolume
        {
            get { return this._supportsDedicatedLogVolume.GetValueOrDefault(); }
            set { this._supportsDedicatedLogVolume = value; }
        }

        // Check to see if SupportsDedicatedLogVolume property is set
        internal bool IsSetSupportsDedicatedLogVolume()
        {
            return this._supportsDedicatedLogVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidProcessorFeatures. 
        /// <para>
        /// Valid processor features for your DB instance.
        /// </para>
        /// </summary>
        public List<AvailableProcessorFeature> ValidProcessorFeatures
        {
            get { return this._validProcessorFeatures; }
            set { this._validProcessorFeatures = value; }
        }

        // Check to see if ValidProcessorFeatures property is set
        internal bool IsSetValidProcessorFeatures()
        {
            return this._validProcessorFeatures != null && (this._validProcessorFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}