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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTrigger operation.
    /// Updates a trigger definition.
    /// 
    ///  
    /// <para>
    /// Job arguments may be logged. Do not pass plaintext secrets as arguments. Retrieve
    /// secrets from a Glue Connection, Amazon Web Services Secrets Manager or other secret
    /// management mechanism if you intend to keep them within the Job.
    /// </para>
    /// </summary>
    public partial class UpdateTriggerRequest : AmazonGlueRequest
    {
        private string _name;
        private TriggerUpdate _triggerUpdate;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trigger to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property TriggerUpdate. 
        /// <para>
        /// The new values with which to update the trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TriggerUpdate TriggerUpdate
        {
            get { return this._triggerUpdate; }
            set { this._triggerUpdate = value; }
        }

        // Check to see if TriggerUpdate property is set
        internal bool IsSetTriggerUpdate()
        {
            return this._triggerUpdate != null;
        }

    }
}