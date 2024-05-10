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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the UpdateActiveModelVersion operation.
    /// </summary>
    public partial class UpdateActiveModelVersionResponse : AmazonWebServiceResponse
    {
        private long? _currentActiveVersion;
        private string _currentActiveVersionArn;
        private string _modelArn;
        private string _modelName;
        private long? _previousActiveVersion;
        private string _previousActiveVersionArn;

        /// <summary>
        /// Gets and sets the property CurrentActiveVersion. 
        /// <para>
        /// The version that is currently active of the machine learning model for which the active
        /// model version was set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? CurrentActiveVersion
        {
            get { return this._currentActiveVersion; }
            set { this._currentActiveVersion = value; }
        }

        // Check to see if CurrentActiveVersion property is set
        internal bool IsSetCurrentActiveVersion()
        {
            return this._currentActiveVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentActiveVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the machine learning model version that is the current
        /// active model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CurrentActiveVersionArn
        {
            get { return this._currentActiveVersionArn; }
            set { this._currentActiveVersionArn = value; }
        }

        // Check to see if CurrentActiveVersionArn property is set
        internal bool IsSetCurrentActiveVersionArn()
        {
            return this._currentActiveVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the machine learning model for which the active
        /// model version was set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the machine learning model for which the active model version was set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousActiveVersion. 
        /// <para>
        /// The previous version that was active of the machine learning model for which the active
        /// model version was set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? PreviousActiveVersion
        {
            get { return this._previousActiveVersion; }
            set { this._previousActiveVersion = value; }
        }

        // Check to see if PreviousActiveVersion property is set
        internal bool IsSetPreviousActiveVersion()
        {
            return this._previousActiveVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreviousActiveVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the machine learning model version that was the
        /// previous active model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PreviousActiveVersionArn
        {
            get { return this._previousActiveVersionArn; }
            set { this._previousActiveVersionArn = value; }
        }

        // Check to see if PreviousActiveVersionArn property is set
        internal bool IsSetPreviousActiveVersionArn()
        {
            return this._previousActiveVersionArn != null;
        }

    }
}