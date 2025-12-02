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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container for the Amazon S3 Storage Lens configuration.
    /// </summary>
    public partial class StorageLensConfiguration
    {
        private AccountLevel _accountLevel;
        private StorageLensAwsOrg _awsOrg;
        private StorageLensDataExport _dataExport;
        private Exclude _exclude;
        private StorageLensExpandedPrefixesDataExport _expandedPrefixesDataExport;
        private string _id;
        private Include _include;
        private bool? _isEnabled;
        private string _prefixDelimiter;
        private string _storageLensArn;

        /// <summary>
        /// Gets and sets the property AccountLevel. 
        /// <para>
        /// A container for all the account-level configurations of your S3 Storage Lens configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountLevel AccountLevel
        {
            get { return this._accountLevel; }
            set { this._accountLevel = value; }
        }

        // Check to see if AccountLevel property is set
        internal bool IsSetAccountLevel()
        {
            return this._accountLevel != null;
        }

        /// <summary>
        /// Gets and sets the property AwsOrg. 
        /// <para>
        /// A container for the Amazon Web Services organization for this S3 Storage Lens configuration.
        /// </para>
        /// </summary>
        public StorageLensAwsOrg AwsOrg
        {
            get { return this._awsOrg; }
            set { this._awsOrg = value; }
        }

        // Check to see if AwsOrg property is set
        internal bool IsSetAwsOrg()
        {
            return this._awsOrg != null;
        }

        /// <summary>
        /// Gets and sets the property DataExport. 
        /// <para>
        /// A container to specify the properties of your S3 Storage Lens metrics export including,
        /// the destination, schema and format.
        /// </para>
        /// </summary>
        public StorageLensDataExport DataExport
        {
            get { return this._dataExport; }
            set { this._dataExport = value; }
        }

        // Check to see if DataExport property is set
        internal bool IsSetDataExport()
        {
            return this._dataExport != null;
        }

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        /// A container for what is excluded in this configuration. This container can only be
        /// valid if there is no <c>Include</c> container submitted, and it's not empty. 
        /// </para>
        /// </summary>
        public Exclude Exclude
        {
            get { return this._exclude; }
            set { this._exclude = value; }
        }

        // Check to see if Exclude property is set
        internal bool IsSetExclude()
        {
            return this._exclude != null;
        }

        /// <summary>
        /// Gets and sets the property ExpandedPrefixesDataExport. 
        /// <para>
        /// A container that configures your S3 Storage Lens expanded prefixes metrics report.
        /// 
        /// </para>
        /// </summary>
        public StorageLensExpandedPrefixesDataExport ExpandedPrefixesDataExport
        {
            get { return this._expandedPrefixesDataExport; }
            set { this._expandedPrefixesDataExport = value; }
        }

        // Check to see if ExpandedPrefixesDataExport property is set
        internal bool IsSetExpandedPrefixesDataExport()
        {
            return this._expandedPrefixesDataExport != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A container for the Amazon S3 Storage Lens configuration ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Include. 
        /// <para>
        /// A container for what is included in this configuration. This container can only be
        /// valid if there is no <c>Exclude</c> container submitted, and it's not empty. 
        /// </para>
        /// </summary>
        public Include Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null;
        }

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// A container for whether the S3 Storage Lens configuration is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool IsEnabled
        {
            get { return this._isEnabled.GetValueOrDefault(); }
            set { this._isEnabled = value; }
        }

        // Check to see if IsEnabled property is set
        internal bool IsSetIsEnabled()
        {
            return this._isEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrefixDelimiter. 
        /// <para>
        /// A container for all prefix delimiters that are used for object keys in this S3 Storage
        /// Lens configuration. The prefix delimiters determine how S3 Storage Lens counts prefix
        /// depth, by separating the hierarchical levels in object keys.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// If either a prefix delimiter or existing delimiter is undefined, Amazon S3 uses the
        /// delimiter that’s defined.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If both the prefix delimiter and existing delimiter are undefined, S3 uses <c>/</c>
        /// as the default delimiter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When custom delimiters are used, both the prefix delimiter and existing delimiter
        /// must specify the same special character. Otherwise, your request results in an error.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Max=1)]
        public string PrefixDelimiter
        {
            get { return this._prefixDelimiter; }
            set { this._prefixDelimiter = value; }
        }

        // Check to see if PrefixDelimiter property is set
        internal bool IsSetPrefixDelimiter()
        {
            return this._prefixDelimiter != null;
        }

        /// <summary>
        /// Gets and sets the property StorageLensArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 Storage Lens configuration. This property
        /// is read-only and follows the following format: <c> arn:aws:s3:<i>us-east-1</i>:<i>example-account-id</i>:storage-lens/<i>your-dashboard-name</i>
        /// </c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StorageLensArn
        {
            get { return this._storageLensArn; }
            set { this._storageLensArn = value; }
        }

        // Check to see if StorageLensArn property is set
        internal bool IsSetStorageLensArn()
        {
            return this._storageLensArn != null;
        }

    }
}