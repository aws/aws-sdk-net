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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The metadata of a list.
    /// </summary>
    public partial class AllowDenyList
    {
        private string _arn;
        private string _createdTime;
        private string _description;
        private string _name;
        private string _updatedTime;
        private string _variableType;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        ///  The time the list was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the list. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        ///  The time the list was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string UpdatedTime
        {
            get { return this._updatedTime; }
            set { this._updatedTime = value; }
        }

        // Check to see if UpdatedTime property is set
        internal bool IsSetUpdatedTime()
        {
            return this._updatedTime != null;
        }

        /// <summary>
        /// Gets and sets the property VariableType. 
        /// <para>
        ///  The variable type of the list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string VariableType
        {
            get { return this._variableType; }
            set { this._variableType = value; }
        }

        // Check to see if VariableType property is set
        internal bool IsSetVariableType()
        {
            return this._variableType != null;
        }

    }
}