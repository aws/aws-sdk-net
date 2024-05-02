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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
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
namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// The information about the resource.
    /// </summary>
    public partial class Resource
    {
        private string _arn;
        private DateTime? _associationTime;
        private ResourceIntegrations _integrations;
        private string _name;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon resource name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
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
        /// Gets and sets the property AssociationTime. 
        /// <para>
        /// The time the resource was associated with the application.
        /// </para>
        /// </summary>
        public DateTime? AssociationTime
        {
            get { return this._associationTime; }
            set { this._associationTime = value; }
        }

        // Check to see if AssociationTime property is set
        internal bool IsSetAssociationTime()
        {
            return this._associationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Integrations. 
        /// <para>
        /// The service integration information about the resource. 
        /// </para>
        /// </summary>
        public ResourceIntegrations Integrations
        {
            get { return this._integrations; }
            set { this._integrations = value; }
        }

        // Check to see if Integrations property is set
        internal bool IsSetIntegrations()
        {
            return this._integrations != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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