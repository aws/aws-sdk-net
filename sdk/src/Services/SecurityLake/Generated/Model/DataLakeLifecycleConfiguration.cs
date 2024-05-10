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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Provides lifecycle details of Amazon Security Lake object.
    /// </summary>
    public partial class DataLakeLifecycleConfiguration
    {
        private DataLakeLifecycleExpiration _expiration;
        private List<DataLakeLifecycleTransition> _transitions = AWSConfigs.InitializeCollections ? new List<DataLakeLifecycleTransition>() : null;

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// Provides data expiration details of Amazon Security Lake object.
        /// </para>
        /// </summary>
        public DataLakeLifecycleExpiration Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration != null;
        }

        /// <summary>
        /// Gets and sets the property Transitions. 
        /// <para>
        /// Provides data storage transition details of Amazon Security Lake object.
        /// </para>
        /// </summary>
        public List<DataLakeLifecycleTransition> Transitions
        {
            get { return this._transitions; }
            set { this._transitions = value; }
        }

        // Check to see if Transitions property is set
        internal bool IsSetTransitions()
        {
            return this._transitions != null && (this._transitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}