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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
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
namespace Amazon.FIS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSafetyLeverState operation.
    /// Updates the specified safety lever state.
    /// </summary>
    public partial class UpdateSafetyLeverStateRequest : AmazonFISRequest
    {
        private string _id;
        private UpdateSafetyLeverStateInput _state;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The ID of the safety lever. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        ///  The state of the safety lever. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateSafetyLeverStateInput State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}