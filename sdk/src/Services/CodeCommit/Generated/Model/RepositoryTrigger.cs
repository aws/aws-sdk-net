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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Information about a trigger for a repository. 
    /// 
    ///  <note> 
    /// <para>
    /// If you want to receive notifications about repository events, consider using notifications
    /// instead of triggers. For more information, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/how-to-repository-email.html">Configuring
    /// notifications for repository events</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RepositoryTrigger
    {
        private List<string> _branches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _customData;
        private string _destinationArn;
        private List<string> _events = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property Branches. 
        /// <para>
        /// The branches to be included in the trigger configuration. If you specify an empty
        /// array, the trigger applies to all branches.
        /// </para>
        ///  <note> 
        /// <para>
        /// Although no content is required in the array, you must include the array itself.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Branches
        {
            get { return this._branches; }
            set { this._branches = value; }
        }

        // Check to see if Branches property is set
        internal bool IsSetBranches()
        {
            return this._branches != null && (this._branches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomData. 
        /// <para>
        /// Any custom data associated with the trigger to be included in the information sent
        /// to the target of the trigger.
        /// </para>
        /// </summary>
        public string CustomData
        {
            get { return this._customData; }
            set { this._customData = value; }
        }

        // Check to see if CustomData property is set
        internal bool IsSetCustomData()
        {
            return this._customData != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The ARN of the resource that is the target for a trigger (for example, the ARN of
        /// a topic in Amazon SNS).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The repository events that cause the trigger to run actions in another service, such
        /// as sending a notification through Amazon SNS. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The valid value "all" cannot be used with any other values.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trigger.
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

    }
}