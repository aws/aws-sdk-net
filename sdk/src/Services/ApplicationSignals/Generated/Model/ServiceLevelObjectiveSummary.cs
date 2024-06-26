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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that contains information about one service level objective (SLO) created
    /// in Application Signals.
    /// </summary>
    public partial class ServiceLevelObjectiveSummary
    {
        private string _arn;
        private DateTime? _createdTime;
        private Dictionary<string, string> _keyAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _name;
        private string _operationName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of this service level objective.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// The date and time that this service level objective was created. It is expressed as
        /// the number of milliseconds since Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// This is a string-to-string map. It can include the following fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Type</c> designates the type of object this service level objective is for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType</c> specifies the type of the resource. This field is used only when
        /// the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> specifies the name of the object. This is used only if the value of the
        /// <c>Type</c> field is <c>Service</c>, <c>RemoteService</c>, or <c>AWS::Service</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Identifier</c> identifies the resource objects of this resource. This is used
        /// only if the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Environment</c> specifies the location where this object is hosted, or what it
        /// belongs to.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public Dictionary<string, string> KeyAttributes
        {
            get { return this._keyAttributes; }
            set { this._keyAttributes = value; }
        }

        // Check to see if KeyAttributes property is set
        internal bool IsSetKeyAttributes()
        {
            return this._keyAttributes != null && (this._keyAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service level objective.
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
        /// Gets and sets the property OperationName. 
        /// <para>
        /// If this service level objective is specific to a single operation, this field displays
        /// the name of that operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OperationName
        {
            get { return this._operationName; }
            set { this._operationName = value; }
        }

        // Check to see if OperationName property is set
        internal bool IsSetOperationName()
        {
            return this._operationName != null;
        }

    }
}