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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The IORM settings of the Exadata DB system.
    /// </summary>
    public partial class ExadataIormConfig
    {
        private List<DbIormConfig> _dbPlans = AWSConfigs.InitializeCollections ? new List<DbIormConfig>() : null;
        private string _lifecycleDetails;
        private IormLifecycleState _lifecycleState;
        private Objective _objective;

        /// <summary>
        /// Gets and sets the property DbPlans. 
        /// <para>
        /// An array of IORM settings for all the database in the Exadata DB system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DbIormConfig> DbPlans
        {
            get { return this._dbPlans; }
            set { this._dbPlans = value; }
        }

        // Check to see if DbPlans property is set
        internal bool IsSetDbPlans()
        {
            return this._dbPlans != null && (this._dbPlans.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LifecycleDetails. 
        /// <para>
        /// Additional information about the current lifecycleState.
        /// </para>
        /// </summary>
        public string LifecycleDetails
        {
            get { return this._lifecycleDetails; }
            set { this._lifecycleDetails = value; }
        }

        // Check to see if LifecycleDetails property is set
        internal bool IsSetLifecycleDetails()
        {
            return this._lifecycleDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleState. 
        /// <para>
        /// The current state of IORM configuration for the Exadata DB system.
        /// </para>
        /// </summary>
        public IormLifecycleState LifecycleState
        {
            get { return this._lifecycleState; }
            set { this._lifecycleState = value; }
        }

        // Check to see if LifecycleState property is set
        internal bool IsSetLifecycleState()
        {
            return this._lifecycleState != null;
        }

        /// <summary>
        /// Gets and sets the property Objective. 
        /// <para>
        /// The current value for the IORM objective. The default is AUTO.
        /// </para>
        /// </summary>
        public Objective Objective
        {
            get { return this._objective; }
            set { this._objective = value; }
        }

        // Check to see if Objective property is set
        internal bool IsSetObjective()
        {
            return this._objective != null;
        }

    }
}