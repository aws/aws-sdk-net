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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// This is the response object from the CreateCustomLogSource operation.
    /// </summary>
    public partial class CreateCustomLogSourceResponse : AmazonWebServiceResponse
    {
        private string _customDataLocation;
        private string _glueCrawlerName;
        private string _glueDatabaseName;
        private string _glueTableName;
        private string _logProviderAccessRoleArn;

        /// <summary>
        /// Gets and sets the property CustomDataLocation. 
        /// <para>
        /// The location of the partition in the Security Lake S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CustomDataLocation
        {
            get { return this._customDataLocation; }
            set { this._customDataLocation = value; }
        }

        // Check to see if CustomDataLocation property is set
        internal bool IsSetCustomDataLocation()
        {
            return this._customDataLocation != null;
        }

        /// <summary>
        /// Gets and sets the property GlueCrawlerName. 
        /// <para>
        /// The name of the Glue crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GlueCrawlerName
        {
            get { return this._glueCrawlerName; }
            set { this._glueCrawlerName = value; }
        }

        // Check to see if GlueCrawlerName property is set
        internal bool IsSetGlueCrawlerName()
        {
            return this._glueCrawlerName != null;
        }

        /// <summary>
        /// Gets and sets the property GlueDatabaseName. 
        /// <para>
        /// The Glue database where results are written, such as: <code>arn:aws:daylight:us-east-1::database/sometable/*</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GlueDatabaseName
        {
            get { return this._glueDatabaseName; }
            set { this._glueDatabaseName = value; }
        }

        // Check to see if GlueDatabaseName property is set
        internal bool IsSetGlueDatabaseName()
        {
            return this._glueDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property GlueTableName. 
        /// <para>
        /// The table name of the Glue crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GlueTableName
        {
            get { return this._glueTableName; }
            set { this._glueTableName = value; }
        }

        // Check to see if GlueTableName property is set
        internal bool IsSetGlueTableName()
        {
            return this._glueTableName != null;
        }

        /// <summary>
        /// Gets and sets the property LogProviderAccessRoleArn. 
        /// <para>
        ///  IAM Role ARN to be used by the entity putting logs into your Custom Source partition.
        /// Security Lake will apply the correct access policies to this Role, but this Role must
        /// have the trust policy created manually. This Role's name must start with the text
        /// 'Security Lake'. It must trust the <code>logProviderAccountId</code> to assume it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LogProviderAccessRoleArn
        {
            get { return this._logProviderAccessRoleArn; }
            set { this._logProviderAccessRoleArn = value; }
        }

        // Check to see if LogProviderAccessRoleArn property is set
        internal bool IsSetLogProviderAccessRoleArn()
        {
            return this._logProviderAccessRoleArn != null;
        }

    }
}