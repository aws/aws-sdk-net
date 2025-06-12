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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// The current status and value of a card in an active Amazon Q App session.
    /// </summary>
    public partial class CardStatus
    {
        private ExecutionStatus _currentState;
        private string _currentValue;
        private List<Submission> _submissions = AWSConfigs.InitializeCollections ? new List<Submission>() : null;

        /// <summary>
        /// Gets and sets the property CurrentState. 
        /// <para>
        /// The current state of the card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionStatus CurrentState
        {
            get { return this._currentState; }
            set { this._currentState = value; }
        }

        // Check to see if CurrentState property is set
        internal bool IsSetCurrentState()
        {
            return this._currentState != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentValue. 
        /// <para>
        /// The current value or result associated with the card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CurrentValue
        {
            get { return this._currentValue; }
            set { this._currentValue = value; }
        }

        // Check to see if CurrentValue property is set
        internal bool IsSetCurrentValue()
        {
            return this._currentValue != null;
        }

        /// <summary>
        /// Gets and sets the property Submissions. 
        /// <para>
        /// A list of previous submissions, if the card is a form card.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Submission> Submissions
        {
            get { return this._submissions; }
            set { this._submissions = value; }
        }

        // Check to see if Submissions property is set
        internal bool IsSetSubmissions()
        {
            return this._submissions != null && (this._submissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}