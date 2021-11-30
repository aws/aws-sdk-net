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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A lens return object.
    /// </summary>
    public partial class Lens
    {
        private string _description;
        private string _lensArn;
        private string _lensVersion;
        private string _name;
        private string _owner;
        private string _shareInvitationId;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LensArn. 
        /// <para>
        /// The ARN of a lens.
        /// </para>
        /// </summary>
        public string LensArn
        {
            get { return this._lensArn; }
            set { this._lensArn = value; }
        }

        // Check to see if LensArn property is set
        internal bool IsSetLensArn()
        {
            return this._lensArn != null;
        }

        /// <summary>
        /// Gets and sets the property LensVersion. 
        /// <para>
        /// The version of a lens.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string LensVersion
        {
            get { return this._lensVersion; }
            set { this._lensVersion = value; }
        }

        // Check to see if LensVersion property is set
        internal bool IsSetLensVersion()
        {
            return this._lensVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services account ID that owns the lens.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property ShareInvitationId. 
        /// <para>
        /// The ID assigned to the share invitation.
        /// </para>
        /// </summary>
        public string ShareInvitationId
        {
            get { return this._shareInvitationId; }
            set { this._shareInvitationId = value; }
        }

        // Check to see if ShareInvitationId property is set
        internal bool IsSetShareInvitationId()
        {
            return this._shareInvitationId != null;
        }

    }
}