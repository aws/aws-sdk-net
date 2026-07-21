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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateQev2IdcApplication operation.
    /// Creates an Amazon Redshift Query Editor (QEV2) IAM Identity Center application.
    /// </summary>
    public partial class CreateQev2IdcApplicationRequest : AmazonRedshiftRequest
    {
        private string _idcDisplayName;
        private string _idcInstanceArn;
        private string _qev2IdcApplicationName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property IdcDisplayName. 
        /// <para>
        /// The display name for the Amazon Redshift Query Editor (QEV2) IAM Identity Center application.
        /// It appears in the console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string IdcDisplayName
        {
            get { return this._idcDisplayName; }
            set { this._idcDisplayName = value; }
        }

        // Check to see if IdcDisplayName property is set
        internal bool IsSetIdcDisplayName()
        {
            return this._idcDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property IdcInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center instance used to create
        /// the Amazon Redshift Query Editor (QEV2) managed application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string IdcInstanceArn
        {
            get { return this._idcInstanceArn; }
            set { this._idcInstanceArn = value; }
        }

        // Check to see if IdcInstanceArn property is set
        internal bool IsSetIdcInstanceArn()
        {
            return this._idcInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Qev2IdcApplicationName. 
        /// <para>
        /// The name of the Amazon Redshift Query Editor (QEV2) application in IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string Qev2IdcApplicationName
        {
            get { return this._qev2IdcApplicationName; }
            set { this._qev2IdcApplicationName = value; }
        }

        // Check to see if Qev2IdcApplicationName property is set
        internal bool IsSetQev2IdcApplicationName()
        {
            return this._qev2IdcApplicationName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the application. Tags are key-value pairs that you
        /// can use to organize and identify your resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}