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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
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
namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Contains configuration information about one output in a feed. It is used in the UpdateFeed
    /// action.
    /// </summary>
    public partial class UpdateOutput
    {
        private string _description;
        private bool? _fromAssociation;
        private string _name;
        private OutputConfig _outputConfig;
        private OutputStatus _status;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the output.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property FromAssociation. 
        /// <para>
        /// This property is set by the service when you add the output to the feed, and indicates
        /// how you added the output. True means that you used the AssociateFeed operation. False
        /// means that you used the CreateFeed or UpdateFeed operation. Use GetFeed to obtain
        /// the value. If the value is True, include this field here with a value of True. If
        /// the value is False, omit the field here.
        /// </para>
        /// </summary>
        public bool? FromAssociation
        {
            get { return this._fromAssociation; }
            set { this._fromAssociation = value; }
        }

        // Check to see if FromAssociation property is set
        internal bool IsSetFromAssociation()
        {
            return this._fromAssociation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name start here
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// A typed property for an output in a feed. It is used in the UpdateFeed action. It
        /// identifies the action for Elemental Inference to perform. It also provides a repository
        /// for the results of that action. For example, CroppingConfig output will contain the
        /// metadata for the crop feature. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}