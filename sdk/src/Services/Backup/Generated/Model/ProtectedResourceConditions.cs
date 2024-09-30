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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// The conditions that you define for resources in your restore testing plan using tags.
    /// </summary>
    public partial class ProtectedResourceConditions
    {
        private List<KeyValue> _stringEquals = AWSConfigs.InitializeCollections ? new List<KeyValue>() : null;
        private List<KeyValue> _stringNotEquals = AWSConfigs.InitializeCollections ? new List<KeyValue>() : null;

        /// <summary>
        /// Gets and sets the property StringEquals. 
        /// <para>
        /// Filters the values of your tagged resources for only those resources that you tagged
        /// with the same value. Also called "exact matching."
        /// </para>
        /// </summary>
        public List<KeyValue> StringEquals
        {
            get { return this._stringEquals; }
            set { this._stringEquals = value; }
        }

        // Check to see if StringEquals property is set
        internal bool IsSetStringEquals()
        {
            return this._stringEquals != null && (this._stringEquals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StringNotEquals. 
        /// <para>
        /// Filters the values of your tagged resources for only those resources that you tagged
        /// that do not have the same value. Also called "negated matching."
        /// </para>
        /// </summary>
        public List<KeyValue> StringNotEquals
        {
            get { return this._stringNotEquals; }
            set { this._stringNotEquals = value; }
        }

        // Check to see if StringNotEquals property is set
        internal bool IsSetStringNotEquals()
        {
            return this._stringNotEquals != null && (this._stringNotEquals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}