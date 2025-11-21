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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The criteria that are evaluated to determine which AMIs are discoverable and usable
    /// in your account for the specified Amazon Web Services Region.
    /// 
    ///  
    /// <para>
    /// The <c>ImageCriteria</c> can include up to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// 10 <c>ImageCriterion</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Each <c>ImageCriterion</c> can include up to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// 200 values for <c>ImageProviders</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 50 values for <c>ImageNames</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 50 values for <c>MarketplaceProductCodes</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-allowed-amis.html#how-allowed-amis-works">How
    /// Allowed AMIs works</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ImageCriterionRequest
    {
        private CreationDateConditionRequest _creationDateCondition;
        private DeprecationTimeConditionRequest _deprecationTimeCondition;
        private List<string> _imageNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _imageProviders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _marketplaceProductCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CreationDateCondition. 
        /// <para>
        /// The maximum age for allowed images.
        /// </para>
        /// </summary>
        public CreationDateConditionRequest CreationDateCondition
        {
            get { return this._creationDateCondition; }
            set { this._creationDateCondition = value; }
        }

        // Check to see if CreationDateCondition property is set
        internal bool IsSetCreationDateCondition()
        {
            return this._creationDateCondition != null;
        }

        /// <summary>
        /// Gets and sets the property DeprecationTimeCondition. 
        /// <para>
        /// The maximum period since deprecation for allowed images.
        /// </para>
        /// </summary>
        public DeprecationTimeConditionRequest DeprecationTimeCondition
        {
            get { return this._deprecationTimeCondition; }
            set { this._deprecationTimeCondition = value; }
        }

        // Check to see if DeprecationTimeCondition property is set
        internal bool IsSetDeprecationTimeCondition()
        {
            return this._deprecationTimeCondition != null;
        }

        /// <summary>
        /// Gets and sets the property ImageNames. 
        /// <para>
        /// The names of allowed images. Names can include wildcards (<c>?</c> and <c>*</c>).
        /// </para>
        ///  
        /// <para>
        /// Length: 1–128 characters. With <c>?</c>, the minimum is 3 characters.
        /// </para>
        ///  
        /// <para>
        /// Valid characters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Letters: <c>A–Z, a–z</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Numbers: <c>0–9</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Special characters: <c>( ) [ ] . / - ' @ _ * ?</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spaces
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Maximum: 50 values
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageNames
        {
            get { return this._imageNames; }
            set { this._imageNames = value; }
        }

        // Check to see if ImageNames property is set
        internal bool IsSetImageNames()
        {
            return this._imageNames != null && (this._imageNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageProviders. 
        /// <para>
        /// The image providers whose images are allowed.
        /// </para>
        ///  
        /// <para>
        /// Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>amazon</c>: Allow AMIs created by Amazon or verified providers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-marketplace</c>: Allow AMIs created by verified providers in the Amazon Web
        /// Services Marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-backup-vault</c>: Allow AMIs created by Amazon Web Services Backup. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 12-digit account ID: Allow AMIs created by the specified accounts. One or more account
        /// IDs can be specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>none</c>: Allow AMIs created by your own account only. When <c>none</c> is specified,
        /// no other values can be specified.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Maximum: 200 values
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageProviders
        {
            get { return this._imageProviders; }
            set { this._imageProviders = value; }
        }

        // Check to see if ImageProviders property is set
        internal bool IsSetImageProviders()
        {
            return this._imageProviders != null && (this._imageProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MarketplaceProductCodes. 
        /// <para>
        /// The Amazon Web Services Marketplace product codes for allowed images.
        /// </para>
        ///  
        /// <para>
        /// Length: 1-25 characters
        /// </para>
        ///  
        /// <para>
        /// Valid characters: Letters (<c>A–Z, a–z</c>) and numbers (<c>0–9</c>)
        /// </para>
        ///  
        /// <para>
        /// Maximum: 50 values
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MarketplaceProductCodes
        {
            get { return this._marketplaceProductCodes; }
            set { this._marketplaceProductCodes = value; }
        }

        // Check to see if MarketplaceProductCodes property is set
        internal bool IsSetMarketplaceProductCodes()
        {
            return this._marketplaceProductCodes != null && (this._marketplaceProductCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}