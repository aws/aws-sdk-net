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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// This is the response object from the GetControl operation.
    /// </summary>
    public partial class GetControlResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private ControlBehavior _behavior;
        private string _description;
        private string _name;
        private RegionConfiguration _regionConfiguration;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=2048)]
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
        /// Gets and sets the property Behavior. 
        /// <para>
        /// A term that identifies the control's functional behavior. One of <c>Preventive</c>,
        /// <c>Deteictive</c>, <c>Proactive</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ControlBehavior Behavior
        {
            get { return this._behavior; }
            set { this._behavior = value; }
        }

        // Check to see if Behavior property is set
        internal bool IsSetBehavior()
        {
            return this._behavior != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of what the control does.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The display name of the control.
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
        /// Gets and sets the property RegionConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public RegionConfiguration RegionConfiguration
        {
            get { return this._regionConfiguration; }
            set { this._regionConfiguration = value; }
        }

        // Check to see if RegionConfiguration property is set
        internal bool IsSetRegionConfiguration()
        {
            return this._regionConfiguration != null;
        }

    }
}