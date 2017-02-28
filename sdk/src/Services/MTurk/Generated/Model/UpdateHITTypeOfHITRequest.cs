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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHITTypeOfHIT operation.
    /// The <code>UpdateHITTypeOfHIT</code> operation allows you to change the HITType properties
    /// of a HIT. This operation disassociates the HIT from its old HITType properties and
    /// associates it with the new HITType properties. The HIT takes on the properties of
    /// the new HITType in place of the old ones.
    /// </summary>
    public partial class UpdateHITTypeOfHITRequest : AmazonMTurkRequest
    {
        private string _hitId;
        private string _hitTypeId;

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        /// The HIT to update.
        /// </para>
        /// </summary>
        public string HITId
        {
            get { return this._hitId; }
            set { this._hitId = value; }
        }

        // Check to see if HITId property is set
        internal bool IsSetHITId()
        {
            return this._hitId != null;
        }

        /// <summary>
        /// Gets and sets the property HITTypeId. 
        /// <para>
        /// The ID of the new HIT type.
        /// </para>
        /// </summary>
        public string HITTypeId
        {
            get { return this._hitTypeId; }
            set { this._hitTypeId = value; }
        }

        // Check to see if HITTypeId property is set
        internal bool IsSetHITTypeId()
        {
            return this._hitTypeId != null;
        }

    }
}