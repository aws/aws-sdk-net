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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// Container for the parameters to the CreateParallelData operation.
    /// Creates a parallel data resource in Amazon Translate by importing an input file from
    /// Amazon S3. Parallel data files contain examples of source phrases and their translations
    /// from your translation memory. By adding parallel data, you can influence the style,
    /// tone, and word choice in your translation output.
    /// </summary>
    public partial class CreateParallelDataRequest : AmazonTranslateRequest
    {
        private string _clientToken;
        private string _description;
        private EncryptionKey _encryptionKey;
        private string _name;
        private ParallelDataConfig _parallelDataConfig;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for the request. This token is automatically generated when you
        /// use Amazon Translate through an AWS SDK.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A custom description for the parallel data resource in Amazon Translate.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property EncryptionKey.
        /// </summary>
        public EncryptionKey EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A custom name for the parallel data resource in Amazon Translate. You must assign
        /// a name that is unique in the account and region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property ParallelDataConfig. 
        /// <para>
        /// Specifies the format and S3 location of the parallel data input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParallelDataConfig ParallelDataConfig
        {
            get { return this._parallelDataConfig; }
            set { this._parallelDataConfig = value; }
        }

        // Check to see if ParallelDataConfig property is set
        internal bool IsSetParallelDataConfig()
        {
            return this._parallelDataConfig != null;
        }

    }
}