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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Details used when updating the replication set.
    /// </summary>
    public partial class UpdateReplicationSetAction
    {
        private AddRegionAction _addRegionAction;
        private DeleteRegionAction _deleteRegionAction;

        /// <summary>
        /// Gets and sets the property AddRegionAction. 
        /// <para>
        /// Details about the Amazon Web Services Region that you're adding to the replication
        /// set.
        /// </para>
        /// </summary>
        public AddRegionAction AddRegionAction
        {
            get { return this._addRegionAction; }
            set { this._addRegionAction = value; }
        }

        // Check to see if AddRegionAction property is set
        internal bool IsSetAddRegionAction()
        {
            return this._addRegionAction != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteRegionAction. 
        /// <para>
        /// Details about the Amazon Web Services Region that you're deleting to the replication
        /// set.
        /// </para>
        /// </summary>
        public DeleteRegionAction DeleteRegionAction
        {
            get { return this._deleteRegionAction; }
            set { this._deleteRegionAction = value; }
        }

        // Check to see if DeleteRegionAction property is set
        internal bool IsSetDeleteRegionAction()
        {
            return this._deleteRegionAction != null;
        }

    }
}