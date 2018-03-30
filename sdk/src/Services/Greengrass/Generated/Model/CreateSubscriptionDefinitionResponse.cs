/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// This is the response object from the CreateSubscriptionDefinition operation.
    /// </summary>
    public partial class CreateSubscriptionDefinitionResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _creationTimestamp;
        private string _id;
        private string _lastUpdatedTimestamp;
        private string _latestVersion;
        private string _latestVersionArn;
        private string _name;

        /// <summary>
        /// Gets and sets the property Arn. The ARN of the definition.
        /// </summary>
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
        /// Gets and sets the property CreationTimestamp. The time, in milliseconds since the
        /// epoch, when the definition was created.
        /// </summary>
        public string CreationTimestamp
        {
            get { return this._creationTimestamp; }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The ID of the definition.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. The time, in milliseconds since the
        /// epoch, when the definition was last updated.
        /// </summary>
        public string LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property LatestVersion. The latest version of the definition.
        /// </summary>
        public string LatestVersion
        {
            get { return this._latestVersion; }
            set { this._latestVersion = value; }
        }

        // Check to see if LatestVersion property is set
        internal bool IsSetLatestVersion()
        {
            return this._latestVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LatestVersionArn. The ARN of the latest version of the
        /// definition.
        /// </summary>
        public string LatestVersionArn
        {
            get { return this._latestVersionArn; }
            set { this._latestVersionArn = value; }
        }

        // Check to see if LatestVersionArn property is set
        internal bool IsSetLatestVersionArn()
        {
            return this._latestVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the definition.
        /// </summary>
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