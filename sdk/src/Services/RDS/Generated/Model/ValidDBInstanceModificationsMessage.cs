/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Information about valid modifications that you can make to your DB instance. Contains
    /// the result of a successful call to the <a>DescribeValidDBInstanceModifications</a>
    /// action. You can use this information when you call <a>ModifyDBInstance</a>.
    /// </summary>
    public partial class ValidDBInstanceModificationsMessage
    {
        private List<ValidStorageOptions> _storage = new List<ValidStorageOptions>();
        private List<AvailableProcessorFeature> _validProcessorFeatures = new List<AvailableProcessorFeature>();

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
            return this._storage != null && this._storage.Count > 0; 
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
            return this._validProcessorFeatures != null && this._validProcessorFeatures.Count > 0; 
        }

    }
}