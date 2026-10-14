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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
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
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Contains lifecycle information for an Amazon Web Services service version, including
    /// lifecycle events and version recommendations.
    /// </summary>
    public partial class ServiceLifecycle
    {
        private List<LifecycleEvent> _lifecycleEvents = AWSConfigs.InitializeCollections ? new List<LifecycleEvent>() : null;
        private string _recommendedVersion;
        private string _service;
        private string _title;
        private string _version;

        /// <summary>
        /// Gets and sets the property LifecycleEvents. 
        /// <para>
        /// The list of lifecycle events for this service version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecycleEvent> LifecycleEvents
        {
            get { return this._lifecycleEvents; }
            set { this._lifecycleEvents = value; }
        }

        // Check to see if LifecycleEvents property is set
        internal bool IsSetLifecycleEvents()
        {
            return this._lifecycleEvents != null && (this._lifecycleEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecommendedVersion. 
        /// <para>
        /// The recommended version to upgrade to.
        /// </para>
        /// </summary>
        public string RecommendedVersion
        {
            get { return this._recommendedVersion; }
            set { this._recommendedVersion = value; }
        }

        // Check to see if RecommendedVersion property is set
        internal bool IsSetRecommendedVersion()
        {
            return this._recommendedVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The name of the Amazon Web Services service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=30)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A human-readable title for the lifecycle entry.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the service.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}