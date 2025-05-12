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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSpace operation.
    /// Updates the settings of a space.
    /// 
    ///  <note> 
    /// <para>
    /// You can't edit the app type of a space in the <c>SpaceSettings</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateSpaceRequest : AmazonSageMakerRequest
    {
        private string _domainId;
        private string _spaceDisplayName;
        private string _spaceName;
        private SpaceSettings _spaceSettings;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the associated domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceDisplayName. 
        /// <para>
        /// The name of the space that appears in the Amazon SageMaker Studio UI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string SpaceDisplayName
        {
            get { return this._spaceDisplayName; }
            set { this._spaceDisplayName = value; }
        }

        // Check to see if SpaceDisplayName property is set
        internal bool IsSetSpaceDisplayName()
        {
            return this._spaceDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceSettings. 
        /// <para>
        /// A collection of space settings.
        /// </para>
        /// </summary>
        public SpaceSettings SpaceSettings
        {
            get { return this._spaceSettings; }
            set { this._spaceSettings = value; }
        }

        // Check to see if SpaceSettings property is set
        internal bool IsSetSpaceSettings()
        {
            return this._spaceSettings != null;
        }

    }
}