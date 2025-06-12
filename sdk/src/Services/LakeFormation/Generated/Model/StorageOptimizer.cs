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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure describing the configuration and details of a storage optimizer.
    /// </summary>
    public partial class StorageOptimizer
    {
        private Dictionary<string, string> _config = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _errorMessage;
        private string _lastRunDetails;
        private OptimizerType _storageOptimizerType;
        private string _warnings;

        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// A map of the storage optimizer configuration. Currently contains only one key-value
        /// pair: <c>is_enabled</c> indicates true or false for acceleration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Config
        {
            get { return this._config; }
            set { this._config = value; }
        }

        // Check to see if Config property is set
        internal bool IsSetConfig()
        {
            return this._config != null && (this._config.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A message that contains information about any error (if present).
        /// </para>
        ///  
        /// <para>
        /// When an acceleration result has an enabled status, the error message is empty.
        /// </para>
        ///  
        /// <para>
        /// When an acceleration result has a disabled status, the message describes an error
        /// or simply indicates "disabled by the user".
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunDetails. 
        /// <para>
        /// When an acceleration result has an enabled status, contains the details of the last
        /// job run.
        /// </para>
        /// </summary>
        public string LastRunDetails
        {
            get { return this._lastRunDetails; }
            set { this._lastRunDetails = value; }
        }

        // Check to see if LastRunDetails property is set
        internal bool IsSetLastRunDetails()
        {
            return this._lastRunDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StorageOptimizerType. 
        /// <para>
        /// The specific type of storage optimizer. The supported value is <c>compaction</c>.
        /// </para>
        /// </summary>
        public OptimizerType StorageOptimizerType
        {
            get { return this._storageOptimizerType; }
            set { this._storageOptimizerType = value; }
        }

        // Check to see if StorageOptimizerType property is set
        internal bool IsSetStorageOptimizerType()
        {
            return this._storageOptimizerType != null;
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// A message that contains information about any warnings (if present).
        /// </para>
        /// </summary>
        public string Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null;
        }

    }
}