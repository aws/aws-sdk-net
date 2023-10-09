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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplication operation.
    /// This API is in preview release and subject to change.
    /// 
    ///  
    /// <para>
    /// Updates and persists an Application resource.
    /// </para>
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonAppIntegrationsServiceRequest
    {
        private ApplicationSourceConfig _applicationSourceConfig;
        private string _arn;
        private string _description;
        private string _name;
        private List<Publication> _publications = new List<Publication>();
        private List<Subscription> _subscriptions = new List<Subscription>();

        /// <summary>
        /// Gets and sets the property ApplicationSourceConfig. 
        /// <para>
        /// The configuration for where the application should be loaded from.
        /// </para>
        /// </summary>
        public ApplicationSourceConfig ApplicationSourceConfig
        {
            get { return this._applicationSourceConfig; }
            set { this._applicationSourceConfig = value; }
        }

        // Check to see if ApplicationSourceConfig property is set
        internal bool IsSetApplicationSourceConfig()
        {
            return this._applicationSourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Application.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Publications. 
        /// <para>
        /// The events that the application publishes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Publication> Publications
        {
            get { return this._publications; }
            set { this._publications = value; }
        }

        // Check to see if Publications property is set
        internal bool IsSetPublications()
        {
            return this._publications != null && this._publications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subscriptions. 
        /// <para>
        /// The events that the application subscribes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Subscription> Subscriptions
        {
            get { return this._subscriptions; }
            set { this._subscriptions = value; }
        }

        // Check to see if Subscriptions property is set
        internal bool IsSetSubscriptions()
        {
            return this._subscriptions != null && this._subscriptions.Count > 0; 
        }

    }
}