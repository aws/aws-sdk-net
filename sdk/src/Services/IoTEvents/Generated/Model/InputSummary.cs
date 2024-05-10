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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Information about the input.
    /// </summary>
    public partial class InputSummary
    {
        private DateTime? _creationTime;
        private string _inputArn;
        private string _inputDescription;
        private string _inputName;
        private DateTime? _lastUpdateTime;
        private InputStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the input was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputArn. 
        /// <para>
        /// The ARN of the input.
        /// </para>
        /// </summary>
        public string InputArn
        {
            get { return this._inputArn; }
            set { this._inputArn = value; }
        }

        // Check to see if InputArn property is set
        internal bool IsSetInputArn()
        {
            return this._inputArn != null;
        }

        /// <summary>
        /// Gets and sets the property InputDescription. 
        /// <para>
        /// A brief description of the input.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string InputDescription
        {
            get { return this._inputDescription; }
            set { this._inputDescription = value; }
        }

        // Check to see if InputDescription property is set
        internal bool IsSetInputDescription()
        {
            return this._inputDescription != null;
        }

        /// <summary>
        /// Gets and sets the property InputName. 
        /// <para>
        /// The name of the input.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string InputName
        {
            get { return this._inputName; }
            set { this._inputName = value; }
        }

        // Check to see if InputName property is set
        internal bool IsSetInputName()
        {
            return this._inputName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The last time the input was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the input.
        /// </para>
        /// </summary>
        public InputStatus Status
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