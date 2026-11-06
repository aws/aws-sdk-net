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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AccountLevel. 
        /// <para>
        /// A container for all the account-level configurations of your S3 Storage Lens configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccountLevel AccountLevel { get; set; }

        /// <summary>
        /// Checks to see if the AccountLevel property is set.
        /// </summary>
        internal bool IsSetAccountLevel() => this.AccountLevel != null;

        /// <summary>
        /// Gets and sets the property AwsOrg. 
        /// <para>
        /// A container for the Amazon Web Services organization for this S3 Storage Lens configuration.
        /// </para>
        /// </summary>
        public StorageLensAwsOrg AwsOrg { get; set; }

        /// <summary>
        /// Checks to see if the AwsOrg property is set.
        /// </summary>
        internal bool IsSetAwsOrg() => this.AwsOrg != null;

        /// <summary>
        /// Gets and sets the property DataExport. 
        /// <para>
        /// A container to specify the properties of your S3 Storage Lens metrics export including,
        /// the destination, schema and format.
        /// </para>
        /// </summary>
        public StorageLensDataExport DataExport { get; set; }

        /// <summary>
        /// Checks to see if the DataExport property is set.
        /// </summary>
        internal bool IsSetDataExport() => this.DataExport != null;

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        /// A container for what is excluded in this configuration. This container can only be
        /// valid if there is no <c>Include</c> container submitted, and it's not empty. 
        /// </para>
        /// </summary>
        public Exclude Exclude { get; set; }

        /// <summary>
        /// Checks to see if the Exclude property is set.
        /// </summary>
        internal bool IsSetExclude() => this.Exclude != null;

        /// <summary>
        /// Gets and sets the property ExpandedPrefixesDataExport. 
        /// <para>
        /// A container that configures your S3 Storage Lens expanded prefixes metrics report.
        /// 
        /// </para>
        /// </summary>
        public StorageLensExpandedPrefixesDataExport ExpandedPrefixesDataExport { get; set; }

        /// <summary>
        /// Checks to see if the ExpandedPrefixesDataExport property is set.
        /// </summary>
        internal bool IsSetExpandedPrefixesDataExport() => this.ExpandedPrefixesDataExport != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A container for the Amazon S3 Storage Lens configuration ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// A container for what is included in this configuration. This container can only be
        /// valid if there is no <c>Exclude</c> container submitted, and it's not empty. 
        /// </para>
        /// </summary>
        public Include Include { get; set; }

        /// <summary>
        /// Checks to see if the Include property is set.
        /// </summary>
        internal bool IsSetInclude() => this.Include != null;

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// A container for whether the S3 Storage Lens configuration is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsEnabled property is set.
        /// </summary>
        internal bool IsSetIsEnabled() => this.IsEnabled.HasValue;

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
        [AWSProperty(Min = 0, Max = 1)]
        public string PrefixDelimiter { get; set; }

        /// <summary>
        /// Checks to see if the PrefixDelimiter property is set.
        /// </summary>
        internal bool IsSetPrefixDelimiter() => this.PrefixDelimiter != null;

        /// <summary>
        /// Gets and sets the property StorageLensArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 Storage Lens configuration. This property
        /// is read-only and follows the following format: <c> arn:aws:s3:<i>us-east-1</i>:<i>example-account-id</i>:storage-lens/<i>your-dashboard-name</i>
        /// </c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StorageLensArn { get; set; }

        /// <summary>
        /// Checks to see if the StorageLensArn property is set.
        /// </summary>
        internal bool IsSetStorageLensArn() => this.StorageLensArn != null;
    }
}
