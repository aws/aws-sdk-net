/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

using Amazon.EC2.Model;
using Amazon.EC2.Util;

using Amazon.Util;
using Amazon.Runtime;

namespace Amazon.EC2
{
    /// <summary>
    /// AmazonEC2Client is an implementation of AmazonEC2;
    /// the client allows you to manage your AmazonEC2 resources.<br />
    /// If you want to use the AmazonEC2Client from a Medium Trust
    /// hosting environment, please create the client with an
    /// AmazonEC2Config object whose UseSecureStringForAwsSecretKey
    /// property is false.
    /// </summary>
    /// <remarks>
    /// The Amazon Elastic Compute Cloud (Amazon EC2) web
    /// service provides you with
    /// the ability to execute your applications in
    /// Amazon's computing environment.
    /// To use Amazon EC2 you simply:
    /// 1. Create an Amazon Machine Image (AMI) containing all your software,
    /// including your operating system and associated configuration settings,
    /// applications, libraries, etc. Think of this as zipping up the contents
    /// of your hard drive. We provide all the necessary tools to create and
    /// package your AMI.
    /// 2. Upload this AMI to the Amazon S3 (Amazon Simple
    /// Storage Service) service. This gives us reliable,
    /// secure access to your AMI.
    /// 3. Register your AMI with Amazon EC2. This allows us to verify
    /// that your AMI has been uploaded correctly and to allocate a unique
    /// identifier for it.
    /// 4. Use this AMI ID and the Amazon EC2 web service
    /// APIs to run, monitor, and
    /// terminate as many instances of this AMI as
    /// required.
    /// You can also skip the first three steps and choose to launch
    /// an AMI that is provided by Amazon or shared by another user.
    /// While instances are running, you are billed for the computing
    /// and network resources that they consume.
    /// You can also skip the first three steps
    /// and choose to launch an AMI that is
    /// provided by Amazon or shared by
    /// another user.
    /// While instances are running, you are billed for the
    /// computing and network
    /// resources that they consume.
    /// </remarks>
    /// <seealso cref="P:Amazon.EC2.AmazonEC2Config.UseSecureStringForAwsSecretKey"/>
    public class AmazonEC2Client : AmazonEC2
    {
        private bool ownCredentials;
        private AWSCredentials credentials; 
        private AmazonEC2Config config;
        private bool disposed;

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern for the AmazonEC2Client
        /// </summary>
        /// <param name="fDisposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool fDisposing)
        {
            if (!this.disposed)
            {
                if (fDisposing && credentials != null)
                {
                    if (ownCredentials)
                    {
                        credentials.Dispose();
                    }
                    credentials = null;
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The destructor for the client class.
        /// </summary>
        ~AmazonEC2Client()
        {
            this.Dispose(false);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonEC2Client()
            : this(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2Config(), true) { }

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        public AmazonEC2Client(RegionEndpoint region)
            : this(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2Config() { RegionEndpoint = region }, true) { }

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonEC2 Configuration Object</param>
        public AmazonEC2Client(AmazonEC2Config config)
            : this(FallbackCredentialsFactory.GetCredentials(), config, true) { }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), new AmazonEC2Config(), true) { }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect to.</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), new AmazonEC2Config() { RegionEndpoint = region }, true) { }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEC2 Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The AmazonEC2 Configuration Object</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonEC2Config config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, true) { }

        /// <summary>
        /// Constructs an AmazonEC2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEC2 Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The AmazonEC2 Configuration Object</param>
        public AmazonEC2Client(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonEC2Config config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, true) { }

        /// <summary>
        /// Constructs an AmazonEC2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEC2 Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="region">The region to connect to.</param>
        public AmazonEC2Client(string awsAccessKeyId, SecureString awsSecretAccessKey, RegionEndpoint region)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), new AmazonEC2Config() { RegionEndpoint = region }, true) { }

        /// <summary>
        /// Constructs an AmazonEC2Client with AWSCredentials
        /// </summary>
        /// <param name="credentials"></param>
        public AmazonEC2Client(AWSCredentials credentials)
            : this(credentials, new AmazonEC2Config(), false) { }

        /// <summary>
        /// Constructs an AmazonEC2Client with AWSCredentials
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="region">The region to connect to.</param>
        public AmazonEC2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEC2Config() { RegionEndpoint = region }, false) { }

        /// <summary>
        /// Constructs an AmazonEC2Client with AWSCredentials and an AmazonEC2 Configuration object
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="config"></param>
        public AmazonEC2Client(AWSCredentials credentials, AmazonEC2Config config)
            : this(credentials, config, false) { }

        // Constructs an AmazonEC2Client with credentials, config and flag which
        // specifies if the credentials are owned by the client or not
        private AmazonEC2Client(AWSCredentials credentials, AmazonEC2Config config, bool ownCredentials)
        {
            this.credentials = credentials;
            this.config = config;
            this.ownCredentials = ownCredentials;
        }

        #endregion

        #region Public API

        /// <summary>
        /// Activates a license.
        /// </summary>
        /// <remarks>
        /// Activates a specific number of licenses for a 90-day period.
        /// Activations can be done against a specific license ID.
        /// </remarks>
        /// <param name="request">Activate License  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Activate License  Response from the service</returns>
        public ActivateLicenseResponse ActivateLicense(ActivateLicenseRequest request)
        {
            return Invoke<ActivateLicenseResponse>(ConvertActivateLicense(request));
        }

        /// <summary>
        /// Acquires an elastic IP address for use with your account or your VPC.
        /// </summary>
        /// <param name="request">Allocate Address  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Allocate Address  Response from the service</returns>
        public AllocateAddressResponse AllocateAddress(AllocateAddressRequest request)
        {
            return Invoke<AllocateAddressResponse>(ConvertAllocateAddress(request));
        }

        /// <summary>
        /// Associates an elastic IP address with an instance. If the IP address is
        /// currently assigned to another instance, the IP address is assigned
        /// to the new instance.
        /// </summary>
        /// <remarks>
        /// This is an idempotent operation. If you call it more than once, Amazon EC2 does not return an error.
        /// </remarks>
        /// <param name="request">Associate Address  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Associate Address  Response from the service</returns>
        public AssociateAddressResponse AssociateAddress(AssociateAddressRequest request)
        {
            return Invoke<AssociateAddressResponse>(ConvertAssociateAddress(request));
        }

        /// <summary>
        /// Attaches an Amazon EBS volume to a running instance and exposes it with the
        /// specified device name.
        /// </summary>
        /// <remarks>
        /// Windows instances currently support devices xvda through xvdp. Devices
        /// xvda and xvdb are reserved by the operating system, xvdc is
        /// assigned to drive C:\, and, depending on the instance type, devices xvdd through
        /// xvde might be reserved by the instance stores. Any device that is not
        /// reserved can be attached to an Amazon EBS volume. For a list of
        /// devices that are reserved by the instance stores, go to the Amazon
        /// Elastic Compute Cloud Developer Guide.
        /// </remarks>
        /// <param name="request">Attach Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Attach Volume  Response from the service</returns>
        public AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
        {
            return Invoke<AttachVolumeResponse>(ConvertAttachVolume(request));
        }

        /// <summary>
        /// Adds one or more ingress rules to a security group.
        /// This action applies to both EC2 security groups and VPC security groups.
        /// </summary>
        /// <remarks>
        /// Permissions are specified by the IP protocol (TCP, UDP or ICMP),
        /// the source of the request (by IP range or an Amazon EC2 user-group pair),
        /// the source and destination port ranges (for TCP and UDP), and the
        /// ICMP codes and types (for ICMP). When authorizing ICMP, -1 can
        /// be used as a wildcard in the type and code fields.
        ///
        /// Permission changes are propagated to instances within the
        /// security group as quickly as possible. However, depending on
        /// the number of instances, a small delay might occur.
        ///
        /// When authorizing a user/group pair permission,
        /// GroupName, SourceSecurityGroupName and SourceSecurityGroupOwnerId
        /// must be specified. When authorizing a CIDR IP permission,
        /// GroupName, IpProtocol, FromPort, ToPort and CidrIp must be specified
        /// </remarks>
        /// <param name="request">Authorize Security Group Ingress  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Authorize Security Group Ingress  Response from the service</returns>
        public AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request)
        {
            return Invoke<AuthorizeSecurityGroupIngressResponse>(ConvertAuthorizeSecurityGroupIngress(request));
        }

        /// <summary>
        /// Bundles an Amazon instance store-backed Windows instance.
        /// This procedure is not applicable for Linux and UNIX instances.
        /// During bundling, only the root device volume (C:\) is bundled. Data on other instance store volumes is not preserved.
        /// </summary>
        /// <param name="request">Bundle Instance  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Bundle Instance  Response from the service</returns>
        public BundleInstanceResponse BundleInstance(BundleInstanceRequest request)
        {
            ImmutableCredentials immutableCredentials = null;
            try
            {
                S3Storage s3 = request.Storage.S3;
                // Check to see if S3 upload policy was set on request.
                // If not, generate. Set expiration to 24 hours.
                if (!s3.IsSetUploadPolicy())
                {
                    immutableCredentials = credentials.GetCredentials();
                    s3.AWSAccessKeyId = immutableCredentials.AccessKey;
                    S3UploadPolicy policy;
                    if (immutableCredentials.UseSecureStringForSecretKey)
                    {
                        policy = new S3UploadPolicy(
                            immutableCredentials.AccessKey,
                            immutableCredentials.SecureSecretKey,
                            s3.Bucket,
                            s3.Prefix,
                            1440
                            );
                    }
                    else
                    {
                        policy = new S3UploadPolicy(
                            immutableCredentials.ClearSecretKey,
                            s3.Bucket,
                            s3.Prefix,
                            1440
                            );
                    }

                    s3.UploadPolicy = policy.PolicyString;
                    s3.UploadPolicySignature = policy.PolicySignature;
                }
                return Invoke<BundleInstanceResponse>(ConvertBundleInstance(request), immutableCredentials);
            }
            finally
            {
                if (immutableCredentials != null)
                    immutableCredentials.Dispose();
            }
        }

        /// <summary>
        /// Cancels a bundling operation for an instance store-backed Windows instance.
        /// </summary>
        /// <param name="request">Cancel Bundle Task  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Cancel Bundle Task  Response from the service</returns>
        public CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request)
        {
            return Invoke<CancelBundleTaskResponse>(ConvertCancelBundleTask(request));
        }

        /// <summary>
        /// Determines whether a product code is associated with an instance.
        /// </summary>
        /// <remarks>
        /// This action can only be used by the owner of the product code.
        /// It is useful when a product code owner needs to verify whether another EC2 user’s
        /// instance is eligible for support.
        /// </remarks>
        /// <param name="request">Confirm Product Instance  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Confirm Product Instance  Response from the service</returns>
        public ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request)
        {
            return Invoke<ConfirmProductInstanceResponse>(ConvertConfirmProductInstance(request));
        }

        /// <summary>
        /// Creates an AMI that uses an Amazon EBS root device from a "running" or
        /// "stopped" instance. AMIs that use an Amazon EBS root device boot
        /// faster than AMIs that use instance stores. They can be up to 1 TiB in size,
        /// use storage that persists on instance failure, and can be stopped
        /// and started.
        /// </summary>
        /// <param name="request">Create Image  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Image  Response from the service</returns>
        public CreateImageResponse CreateImage(CreateImageRequest request)
        {
            return Invoke<CreateImageResponse>(ConvertCreateImage(request));
        }

        /// <summary>
        /// Creates a new 2048-bit RSA key pair with the specified name. The public
        /// key is stored by Amazon EC2 and the private key is returned to you.
        /// </summary>
        /// <remarks>
        /// The private key is returned as an unencrypted PEM encoded PKCS#8 private key.
        /// If a key with the specified name already exists, Amazon EC2 returns an error.
        /// The key pair returned to you works only in the Region you're using when you
        /// create the key pair. To create a key pair that works in all Regions, use ImportKeyPair.
        /// </remarks>
        /// <param name="request">Create Key Pair  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Key Pair  Response from the service</returns>
        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            return Invoke<CreateKeyPairResponse>(ConvertCreateKeyPair(request));
        }

        /// <summary>
        /// Creates a PlacementGroup into which multiple Amazon EC2
        /// instances can be launched. Users must give the group a
        /// name unique within the scope of the user account.
        /// </summary>
        /// <param name="request">Create Placement Group  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Placement Group  Response from the service</returns>
        public CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request)
        {
            return Invoke<CreatePlacementGroupResponse>(ConvertCreatePlacementGroup(request));
        }

        /// <summary>
        /// Creates a new security group. Group names must be
        /// unique per account.
        /// </summary>
        /// <remarks>
        /// Every instance is launched in a security group.
        /// If no security group is specified during launch,
        /// the instances are launched in the default security group.
        /// Instances within the same security group have unrestricted network
        /// access to each other. Instances will reject network access attempts from
        /// other instances in a different security group. As the owner of instances you
        /// can grant or revoke specific permissions using the
        /// AuthorizeSecurityGroupIngress and RevokeSecurityGroupIngress
        /// operations.
        /// </remarks>
        /// <param name="request">Create Security Group  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Security Group  Response from the service</returns>
        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            return Invoke<CreateSecurityGroupResponse>(ConvertCreateSecurityGroup(request));
        }

        /// <summary>
        /// Creates a snapshot of an Amazon EBS volume and stores it in Amazon S3.
        /// You can use snapshots for backups, to make identical copies of instance
        /// devices, and to save data before shutting down an instance.
        /// </summary>
        /// <remarks>
        /// When taking a snapshot of a file system, we recommend unmounting it
        /// first. This ensures the file system metadata is in a consistent state,
        /// that the 'mounted indicator' is cleared, and that all applications
        /// using that file system are stopped and in a consistent state. Some file
        /// systems, such as xfs, can freeze and unfreeze activity so a
        /// snapshot can be made without unmounting.
        ///
        /// For Linux/UNIX, enter the
        /// following command from the command line.
        ///
        /// umount -d /dev/sdh
        ///
        /// For Windows, open Disk Management, right-click the volume to unmount,
        /// and select Change Drive Letter and Path. Then, select the mount
        /// point to remove and click Remove.
        /// </remarks>
        /// <param name="request">Create Snapshot  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Snapshot  Response from the service</returns>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            return Invoke<CreateSnapshotResponse>(ConvertCreateSnapshot(request));
        }

        /// <summary>
        /// Adds or overwrites tags for the specified resources. 
        /// Each resource can have a maximum of 10 tags. 
        /// Each tag consists of a key-value pair.
        /// Tag keys must be unique per resource.
        /// </summary>
        /// <param name="request">Create Tags  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Tags  Response from the service</returns>
        public CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            return Invoke<CreateTagsResponse>(ConvertCreateTags(request));
        }

        /// <summary>
        /// Creates a new Amazon EBS volume that can be attached to any Amazon EC2
        /// instance in the same Availability Zone.
        /// Any AWS Marketplace product codes from the snapshot are propagated to the volume.
        /// </summary>
        /// <param name="request">Create Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Volume  Response from the service</returns>
        public CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
        {
            return Invoke<CreateVolumeResponse>(ConvertCreateVolume(request));
        }

        /// <summary>
        /// Deactivates a specific number of licenses.
        /// </summary>
        /// <remarks>
        /// Deactivations can be done against a specific license ID
        /// after they have persisted for at least a 90-day period.
        /// </remarks>
        /// <param name="request">Deactivate License  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Deactivate License  Response from the service</returns>
        public DeactivateLicenseResponse DeactivateLicense(DeactivateLicenseRequest request)
        {
            return Invoke<DeactivateLicenseResponse>(ConvertDeactivateLicense(request));
        }

        /// <summary>
        /// Deletes the specified key pair, by removing the
        /// public key from Amazon EC2. You must own the key pair.
        /// </summary>
        /// <param name="request">Delete Key Pair  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Key Pair  Response from the service</returns>
        public DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            return Invoke<DeleteKeyPairResponse>(ConvertDeleteKeyPair(request));
        }

        /// <summary>
        /// Deletes a PlacementGroupfrom a user's account.
        /// Terminate all Amazon EC2 instances in the placement group before
        /// deletion.
        /// </summary>
        /// <param name="request">Delete Placement Group  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Placement Group  Response from the service</returns>
        public DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request)
        {
            return Invoke<DeletePlacementGroupResponse>(ConvertDeletePlacementGroup(request));
        }

        /// <summary>
        /// Deletes a security group that you own.
        /// </summary>
        ///<remarks>
        /// If you attempt to delete a security group that contains instances, an
        /// error is returned.
        ///
        /// If you attempt to delete a security group that is referenced by
        /// another security group, an error is returned. For example,
        /// if security group B has a rule that allows access from
        /// security group A, security group A cannot be deleted until the
        /// allow rule is removed.
        /// </remarks>
        /// <param name="request">Delete Security Group  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Security Group  Response from the service</returns>
        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            return Invoke<DeleteSecurityGroupResponse>(ConvertDeleteSecurityGroup(request));
        }

        /// <summary>
        /// Deletes a snapshot of an Amazon EBS volume that you own.
        /// </summary>
        /// <param name="request">Delete Snapshot  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Snapshot  Response from the service</returns>
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            return Invoke<DeleteSnapshotResponse>(ConvertDeleteSnapshot(request));
        }

        /// <summary>
        /// Deletes tags from the specified resources.
        /// </summary>
        /// <param name="request">Delete Tags  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Tags  Response from the service</returns>
        public DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            return Invoke<DeleteTagsResponse>(ConvertDeleteTags(request));
        }

        /// <summary>
        /// Deletes an Amazon EBS volume that you own.
        /// The volume must be in the available state (not attached to an instance).
        /// </summary>
        /// <param name="request">Delete Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Volume  Response from the service</returns>
        public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            return Invoke<DeleteVolumeResponse>(ConvertDeleteVolume(request));
        }

        /// <summary>
        /// Deregisters the specified AMI. Once deregistered,
        /// the AMI cannot be used to launch new instances.
        /// </summary>
        /// <remarks>
        /// This command does not delete the AMI from Amazon S3.
        /// </remarks>
        /// <param name="request">Deregister Image  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Deregister Image  Response from the service</returns>
        public DeregisterImageResponse DeregisterImage(DeregisterImageRequest request)
        {
            return Invoke<DeregisterImageResponse>(ConvertDeregisterImage(request));
        }

        /// <summary>
        /// Lists elastic IP addresses assigned to your
        /// account or provides information about a
        /// specific address.
        /// </summary>
        /// <param name="request">Describe Addresses  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Addresses  Response from the service</returns>
        public DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
        {
            return Invoke<DescribeAddressesResponse>(ConvertDescribeAddresses(request));
        }

        /// <summary>
        /// Lists Availability Zones that are currently
        /// available to the account and their states.
        /// </summary>
        /// <remarks>
        /// Availability Zones are not the same across accounts.
        /// The Availability Zone us-east-1a for account A is not
        /// necessarily the same as us-east-1a for account B.
        /// Zone assignments are mapped independently for each account.
        /// </remarks>
        /// <param name="request">Describe Availability Zones  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Availability Zones  Response from the service</returns>
        public DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
        {
            return Invoke<DescribeAvailabilityZonesResponse>(ConvertDescribeAvailabilityZones(request));
        }

        /// <summary>
        /// Describes current bundling tasks.
        /// </summary>
        /// <remarks>
        /// Describes in-progress and recent bundle tasks.
        /// Complete and failed tasks are removed from the list a
        /// short time after completion.
        /// If no bundle ids are given, all bundle tasks are returned.
        /// </remarks>
        /// <param name="request">Describe Bundle Tasks  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Bundle Tasks  Response from the service</returns>
        public DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request)
        {
            return Invoke<DescribeBundleTasksResponse>(ConvertDescribeBundleTasks(request));
        }

        /// <summary>
        /// Provides details of a user's registered licenses.
        /// </summary>
        /// <remarks>
        /// Zero or more IDs may be specified on the call.
        /// When one or more license IDs are specified,
        /// only data for the specified IDs are returned.
        /// </remarks>
        /// <param name="request">Describe Licenses  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Licenses  Response from the service</returns>
        public DescribeLicensesResponse DescribeLicenses(DescribeLicensesRequest request)
        {
            return Invoke<DescribeLicensesResponse>(ConvertDescribeLicenses(request));
        }

        /// <summary>
        /// Returns information about one or more PlacementGroup instances
        /// in a user's account.
        /// </summary>
        /// <param name="request">Describe Placement Groups  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Placement Groups  Response from the service</returns>
        public DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request)
        {
            return Invoke<DescribePlacementGroupsResponse>(ConvertDescribePlacementGroups(request));
        }

        /// <summary>
        /// Returns information about an attribute of a snapshot.
        /// Only one attribute can be specified per call.
        /// </summary>
        /// <param name="request">Describe Snapshot Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Snapshot Attribute  Response from the service</returns>
        public DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request)
        {
            return Invoke<DescribeSnapshotAttributeResponse>(ConvertDescribeSnapshotAttribute(request));
        }

        /// <summary>
        /// Gets information about an attribute of an AMI.
        /// Only one attribute can be specified per call.
        /// </summary>
        /// <param name="request">Describe Image Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Image Attribute  Response from the service</returns>
        public DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request)
        {
            return Invoke<DescribeImageAttributeResponse>(ConvertDescribeImageAttribute(request), DescribeImageAttributeResponse.serializer_UnknownElement);
        }

        /// <summary>
        /// Returns information about AMIs, AKIs, and ARIs.
        /// This includes image type, product codes, architecture, and kernel
        /// and RAM disk IDs. Images available to you include public images,
        /// private images that you own, and private images owned by other
        /// users for which you have explicit launch permissions.
        /// </summary>
        /// <remarks>
        /// Launch permissions fall into three categories:
        ///
        /// 1. public:
        /// The owner of the AMI granted launch permissions for the AMI to the
        /// all group. All users have launch permissions for these AMIs.
        ///
        /// 2. explicit:
        /// The owner of the AMI granted launch permissions to a specific user.
        ///
        /// 3. implicit:
        /// A user has implicit launch permissions for all AMIs he or she
        /// owns.
        ///
        /// The list of AMIs returned can be modified by specifying AMI IDs,
        /// AMI owners, or users with launch permissions. If no options are
        /// specified, Amazon EC2 returns all AMIs for
        /// which the user has launch permissions.
        ///
        /// If you specify one or more AMI IDs, only AMIs that have the
        /// specified IDs are returned. If you specify an invalid AMI
        /// ID, a fault is returned. If you specify an AMI ID for which
        /// you do not have access, it will not be included in the returned
        /// results.
        ///
        /// If you specify one or more AMI owners, only AMIs from the
        /// specified owners and for which you have access are returned. The
        /// results can include the account IDs of the
        /// specified owners, amazon for AMIs owned by Amazon or self for AMIs that you
        /// own.
        ///
        /// If you specify a list of executable users, only users that have
        /// launch permissions for the AMIs are returned. You can specify account IDs
        /// (if you own the AMI(s)), self for AMIs for which you own or have
        /// explicit permissions, or all for public AMIs.
        /// </remarks>
        /// <param name="request">Describe Images  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Images  Response from the service</returns>
        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            return Invoke<DescribeImagesResponse>(ConvertDescribeImages(request), DescribeImagesResponse.serializer_UnknownElement);
        }

        /// <summary>
        /// Describes the status of an Amazon Elastic Compute Cloud (Amazon EC2) instance.
        /// Instance status provides information about two types of scheduled events for
        /// an instance that may require your attention, Scheduled Reboot and Scheduled Retirement.
        /// Only information about instances in the running state is returned.
        /// </summary>
        /// <param name="request">Describe Instance Status request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Instance Status response from the service</returns>
        public DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request)
        {
            return Invoke<DescribeInstanceStatusResponse>(ConvertDescribeInstanceStatus(request));
        }

        /// <summary>
        /// Submits feedback about an instance's status.
        /// </summary>
        /// <remarks>
        /// This action works only for instances that are in the running state.
        /// If your experience with the instance differs from the instance status returned by the 
        /// DescribeInstanceStatus action, use ReportInstanceStatus to report your experience with the instance. 
        /// Amazon EC2 collects this information to improve the accuracy of status checks. 
        /// Use of this action does not change the value returned by DescribeInstanceStatus.
        /// </remarks>
        /// <param name="request">Report Instance Status request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Report Instance Status response from the service</returns>
        public ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request)
        {
            return Invoke<ReportInstanceStatusResponse>(ConvertReportInstanceStatus(request));
        }

        /// <summary>
        /// Returns information about instances that you own.
        /// </summary>
        /// <remarks>
        /// If you specify one or more instance IDs, Amazon EC2 returns
        /// information for those instances.
        ///
        /// If you do not specify instance IDs, Amazon EC2 returns information
        /// for all relevant instances. If you
        /// specify an invalid instance ID, a fault is returned.
        ///
        /// If you specify an instance that you do not own, it will not be
        /// included in the returned results.
        ///
        /// Recently terminated instances might appear in the returned results.This
        /// interval is usually less than one hour.
        /// </remarks>
        /// <param name="request">Describe Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Instances  Response from the service</returns>
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            return Invoke<DescribeInstancesResponse>(ConvertDescribeInstances(request), DescribeInstancesResponse.serializer_UnknownElement);
        }

        /// <summary>
        /// Describes regions that are currently available to
        /// the account.
        /// </summary>
        /// <param name="request">Describe Regions  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Regions  Response from the service</returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            return Invoke<DescribeRegionsResponse>(ConvertDescribeRegions(request));
        }

        /// <summary>
        /// Describes Reserved Instances that you purchased.
        /// </summary>
        /// <remarks>
        /// For more information about Reserved Instances, go to the
        /// Amazon Elastic Compute Cloud Developer Guide.
        /// </remarks>
        /// <param name="request">Describe Reserved Instances  request</param>
        /// <returns>Describe Reserved Instances  Response from the service</returns>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        public DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            return Invoke<DescribeReservedInstancesResponse>(ConvertDescribeReservedInstances(request));
        }

        /// <summary>
        /// Describes Reserved Instance offerings that are available for purchase.
        /// </summary>
        /// <remarks>
        /// With Amazon EC2 Reserved Instances, you purchase the right to launch
        /// Amazon EC2 instances for a period of time (without getting insufficient
        /// capacity errors) and pay a lower usage rate for the actual time used.
        /// For more information about Reserved Instances, go to the Amazon
        /// Elastic Compute Cloud Developer Guide.
        /// </remarks>
        /// <param name="request">Describe Reserved Instances Offerings  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Reserved Instances Offerings  Response from the service</returns>
        public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request)
        {
            return Invoke<DescribeReservedInstancesOfferingsResponse>(ConvertDescribeReservedInstancesOfferings(request));
        }

        /// <summary>
        /// Returns information about key pairs available to
        /// you. If you specify key pairs, information
        /// about those key pairs is returned. Otherwise, information for all
        /// registered key pairs is returned.
        /// </summary>
        /// <param name="request">Describe Key Pairs  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Key Pairs  Response from the service</returns>
        public DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            return Invoke<DescribeKeyPairsResponse>(ConvertDescribeKeyPairs(request));
        }

        /// <summary>
        /// Returns information about security groups that you own.
        /// </summary>
        /// <remarks>
        /// If you specify security group names, information about those security
        /// group is returned. Otherwise, information for all security group is
        /// returned.
        /// If you specify a group that does not exist, a fault is returned.
        /// </remarks>
        /// <param name="request">Describe Security Groups  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Security Groups  Response from the service</returns>
        public DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            return Invoke<DescribeSecurityGroupsResponse>(ConvertDescribeSecurityGroups(request));
        }

        /// <summary>
        /// Returns information about Amazon EBS snapshots available to the user.
        /// </summary>
        /// <remarks>
        /// Information returned includes volume ID, status, start time, progress,
        /// owner ID, volume size, and description. Snapshots available to the user
        /// include public snapshots available for any user to launch, private
        /// snapshots owned by the user making the request, and private snapshots
        /// owned by other users for which the user granted explicit create
        /// volume permissions.
        ///
        /// The create volume permissions fall into 3 categories:
        ///
        /// public
        ///
        /// The owner of the snapshot granted create volume permissions for the
        /// snapshot to the all group. All users have create volume permissions
        /// for these snapshots.
        ///
        /// explicit
        ///
        /// The owner of the snapshot granted create volume permissions to a
        /// specific user.
        ///
        /// implicit
        ///
        /// A user has implicit create volume permissions for all snapshots he
        /// or she owns.
        ///
        /// The list of snapshots returned can be modified by specifying
        /// snapshot IDs, snapshot owners, or users with create volume permissions.
        ///
        /// If no options are specified, Amazon EC2 returns all snapshots for
        /// which the user has create volume permissions.
        ///
        /// If you specify one or more snapshot IDs, only snapshots that have
        /// the specified IDs are returned. If you specify an invalid snapshot ID,
        /// a fault is returned. If you specify a snapshot ID for which you do not
        /// have access, it will not be included in the returned results.
        ///
        /// If you specify one or more snapshot owners, only snapshots from the
        /// specified owners and for which you have access are returned. The
        /// results can include the AWS Account IDs of the specified owners,
        /// amazon for snapshots owned by Amazon or self for snapshots that you own.
        ///
        /// If you specify a list of restorable users, only users that
        /// have create snapshot permissions for the snapshots are returned.
        /// You can specify AWS Account IDs (if you own the snapshot(s)), self for
        /// snapshots for which you own or have explicit permissions, or all for
        /// public snapshots.
        /// </remarks>
        /// <param name="request">Describe Snapshots  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Snapshots  Response from the service</returns>
        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            return Invoke<DescribeSnapshotsResponse>(ConvertDescribeSnapshots(request));
        }

        /// <summary>
        /// Describes Tags for the specified resources.
        /// </summary>
        /// <param name="request">Describe Tags  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Tags  Response from the service</returns>
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            return Invoke<DescribeTagsResponse>(ConvertDescribeTags(request));
        }

        /// <summary>
        /// Describes the specified Amazon EBS volumes that you own.
        /// </summary>
        /// <remarks>
        /// If you do not specify one or more volume IDs, Amazon EBS
        /// describes all volumes that you own.
        /// For more information about Amazon EBS, go to the Amazon
        /// Elastic Compute Cloud Developer Guide.
        /// </remarks>
        /// <param name="request">Describe Volumes  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Volumes  Response from the service</returns>
        public DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            return Invoke<DescribeVolumesResponse>(ConvertDescribeVolumes(request));
        }

        /// <summary>
        /// Detaches an Amazon EBS volume from an instance.
        /// </summary>
        /// <remarks>
        /// For more information about Amazon EBS, go
        /// to the Amazon Elastic Compute Cloud Developer Guide.
        ///
        /// Important - make sure to unmount any file systems
        /// on the device within your operating system before
        /// detaching the volume.
        ///
        /// Failure to unmount file systems, or otherwise
        /// properly release the device from use, can result
        /// in lost data and will corrupt the file system.
        /// </remarks>
        /// <param name="request">Detach Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Detach Volume  Response from the service</returns>
        public DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
        {
            return Invoke<DetachVolumeResponse>(ConvertDetachVolume(request));
        }

        /// <summary>
        /// Disassociates the specified elastic IP address
        /// from the instance to which it is assigned.
        /// </summary>
        /// <remarks>
        /// This is an idempotent operation. If you call it more
        /// than once, Amazon EC2 does not return an error.
        /// </remarks>
        /// <param name="request">Disassociate Address  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Disassociate Address  Response from the service</returns>
        public DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request)
        {
            return Invoke<DisassociateAddressResponse>(ConvertDisassociateAddress(request));
        }

        /// <summary>
        /// Retrieves the encrypted administrator password for the instances running Windows.
        /// </summary>
        /// <remarks>
        /// The Windows password is only generated the first time an AMI is launched.
        /// It is not generated for rebundled AMIs or after the password is
        /// changed on an instance.
        /// The password is encrypted using the key pair that you
        /// provided.
        /// </remarks>
        /// <param name="request">Get Password Data  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Get Password Data  Response from the service</returns>
        public GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request)
        {
            return Invoke<GetPasswordDataResponse>(ConvertGetPasswordData(request));
        }

        /// <summary>
        /// Retrieves console output for the specified instance.
        /// </summary>
        /// <remarks>
        /// Instance console output is buffered and posted shortly
        /// after instance boot, reboot, and termination.
        /// Amazon EC2 preserves the most recent 64 KB output which
        /// will be available for at least one hour after the most
        /// recent post.
        /// </remarks>
        /// <param name="request">Get Console Output  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Get Console Output  Response from the service</returns>
        public GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request)
        {
            return Invoke<GetConsoleOutputResponse>(ConvertGetConsoleOutput(request));
        }

        /// <summary>
        /// Imports the public key from an RSA key pair created with a third-party tool.
        /// </summary>
        /// <remarks>
        /// This operation differs from CreateKeyPair as the private key is never
        /// transferred between the caller and AWS servers.
        ///
        /// RSA key pairs are easily created on Microsoft Windows and Linux OS systems using
        /// the ssh-keygen command line tool provided with the standard OpenSSH
        /// installation. Standard library support for RSA key pair creation is also available
        /// for Java, Ruby, Python, and many other programming languages.
        ///
        /// The following formats are supported:
        /// - OpenSSH public key format,
        /// - Base64 encoded DER format.
        /// - SSH public key file format as specified in RFC4716.
        /// </remarks>
        /// <param name="request">Import Key Pair  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Import Key Pair  Response from the service</returns>
        public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            return Invoke<ImportKeyPairResponse>(ConvertImportKeyPair(request));
        }

        /// <summary>
        /// Adds or remove permission settings for the specified snapshot
        /// </summary>
        /// <param name="request">Modify Snapshot Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Snapshot Attribute  Response from the service</returns>
        public ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            return Invoke<ModifySnapshotAttributeResponse>(ConvertModifySnapshotAttribute(request));
        }

        /// <summary>
        /// Modifies an attribute of an AMI
        /// </summary>
        /// <param name="request">Modify Image Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Image Attribute  Response from the service</returns>
        public ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            return Invoke<ModifyImageAttributeResponse>(ConvertModifyImageAttribute(request));
        }

        /// <summary>
        /// Purchases a Reserved Instance for use with your account.
        /// </summary>
        /// <remarks>
        /// With Amazon EC2 Reserved Instances, you purchase the right
        /// to launch Amazon EC2 instances for a period of time (without
        /// getting insufficient capacity errors) and pay a lower usage rate for
        /// the actual time used.
        /// 
        /// For more information about Reserved Instances, go to the Amazon
        /// Elastic Compute Cloud Developer Guide.
        /// </remarks>
        /// <param name="request">Purchase Reserved Instances Offering  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Purchase Reserved Instances Offering  Response from the service</returns>
        public PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
        {
            return Invoke<PurchaseReservedInstancesOfferingResponse>(ConvertPurchaseReservedInstancesOffering(request));
        }

        /// <summary>
        /// Requests a reboot of one or more instances.
        /// </summary>
        /// <remarks>
        /// This operation is asynchronous; it only queues a request to
        /// reboot the specified instance(s). The operation will succeed if the instances
        /// are valid and belong to you. Requests to reboot terminated instances
        /// are ignored.
        ///
        /// Note - if a Linux/UNIX instance does not cleanly shut
        /// down within four minutes, Amazon EC2 will perform a hard reboot.
        /// </remarks>
        /// <param name="request">Reboot Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reboot Instances  Response from the service</returns>
        public RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
        {
            return Invoke<RebootInstancesResponse>(ConvertRebootInstances(request));
        }

        /// <summary>
        /// Registers an AMI with Amazon EC2.
        /// </summary>
        /// <remarks>
        /// Images must be registered before they can be launched.
        /// To launch instances, use the RunInstances operation.
        ///
        /// Each AMI is associated with an unique ID which is provided by
        /// the Amazon EC2 service through the RegisterImage operation.
        /// During registration, Amazon EC2 retrieves the specified image
        /// manifest from Amazon S3 and verifies that the image is owned
        /// by the user registering the image.
        ///
        /// The image manifest is retrieved once and stored within the Amazon
        /// EC2. Any modifications to an image in Amazon S3 invalidates this
        /// registration. If you make changes to an image, deregister the
        /// previous image and register the new image. To deregister an image,
        /// use the DeregisterImage operation.
        /// </remarks>
        /// <param name="request">Register Image  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Register Image  Response from the service</returns>
        public RegisterImageResponse RegisterImage(RegisterImageRequest request)
        {
            return Invoke<RegisterImageResponse>(ConvertRegisterImage(request));
        }

        /// <summary>
        /// Releases an elastic IP address associated with your account.
        /// </summary>
        ///<remarks>
        /// If you run this operation on an elastic IP address that is
        /// already released, the address might be assigned to another
        /// account which will cause Amazon EC2 to return an error.
        ///
        /// Releasing an IP address automatically disassociates it from any
        /// instance with which it is associated. To disassociate an IP
        /// address without releasing it, use the DisassociateAddress
        /// operation.
        ///
        /// After releasing an elastic IP address, it is
        /// released to the IP // address pool and might no longer be
        /// available to your account. Make sure to update your DNS
        /// records and any servers or devices that communicate with
        /// the address.
        /// </remarks>
        /// <param name="request">Release Address  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Release Address  Response from the service</returns>
        public ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request)
        {
            return Invoke<ReleaseAddressResponse>(ConvertReleaseAddress(request));
        }

        /// <summary>
        /// Resets permission settings for the specified snapshot
        /// </summary>
        /// <param name="request">Reset Snapshot Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reset Snapshot Attribute  Response from the service</returns>
        public ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request)
        {
            return Invoke<ResetSnapshotAttributeResponse>(ConvertResetSnapshotAttribute(request));
        }

        /// <summary>
        /// Resets an attribute of an AMI to its default value.
        /// Note - The productCodes attribute cannot be reset.
        /// </summary>
        /// <param name="request">Reset Image Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reset Image Attribute  Response from the service</returns>
        public ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request)
        {
            return Invoke<ResetImageAttributeResponse>(ConvertResetImageAttribute(request));
        }

        /// <summary>
        /// Revokes permissions from a security group.
        /// </summary>
        /// <remarks>
        /// The permissions used to revoke must be specified using the same values
        /// used to grant the permissions.
        ///
        /// Permissions are specified by IP protocol (TCP, UDP, or ICMP), the source
        /// of the request (by IP range or an Amazon EC2 user-group pair), the
        /// source and destination port ranges (for TCP and UDP), and the ICMP codes
        /// and types (for ICMP).
        ///
        /// Permission changes are quickly propagated to instances within the
        /// security group. However, depending on the number of instances in the group,
        /// a small delay is might occur.
        /// </remarks>
        /// <param name="request">Revoke Security Group Ingress  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Revoke Security Group Ingress  Response from the service</returns>
        public RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request)
        {
            return Invoke<RevokeSecurityGroupIngressResponse>(ConvertRevokeSecurityGroupIngress(request));
        }

        /// <summary>
        /// Launches a specified number of instances of an AMI for which you have permissions.
        /// </summary>
        /// <remarks>
        /// If Amazon EC2 cannot launch the minimum number AMIs you request, no
        /// instances will be launched. If there is insufficient capacity to
        /// launch the maximum number of AMIs you request, Amazon EC2 launches the minimum
        /// number specified for each AMI and allocate the remaining available
        /// instances using round robin.
        ///
        /// In the following example, Libby generates a request to
        /// launch two images (database and web_server):
        ///
        /// Libby runs the RunInstances operation to launch database instances
        /// (min. 10, max. 15) and web_server instances (min. 30, max. 40).
        ///
        /// Because there are currently 30 instances available and Libby needs a
        /// minimum of 40, no instances are launched.
        ///
        /// Libby adjusts the number of instances she needs and runs the
        /// RunInstances operation to launch database
        /// instances (min. 5, max. 10) and web_server
        /// instances (min. 20, max. 40).
        ///
        /// Amazon EC2 launches the minimum number of instances for each
        /// AMI (5 database, 20 web_server).
        ///
        /// The remaining 5 instances are allocated using round robin.
        ///
        /// Libby adjusts the number of instances she needs and runs the RunInstances
        /// operation again to launch database instances (min. 5, max. 10) and
        /// web_server instances (min. 20, max. 40).
        ///
        /// Note - every instance is launched in a security group
        /// (created using the CreateSecurityGroup operation.)
        ///
        /// You can provide an optional key pair ID for each image in the launch request
        /// (created using the CreateKeyPair operation). All instances that
        /// are created from images that use this key pair will have access to
        /// the associated public key at boot. You can use this key to provide
        /// secure access to an instance of an image on a per-instance basis.
        /// Amazon EC2 public images use this feature to provide secure access
        /// without passwords.
        ///
        /// Important - launching public images without a key pair ID will leave them
        /// inaccessible.
        ///
        /// The public key material is made available to the instance at boot
        /// time by placing it in the openssh_id.pub file on a logical device that is exposed
        /// to the instance as /dev/sda2 (the instance store). The format of this
        /// file is suitable for use as an entry within ~/.ssh/authorized_keys
        /// (the OpenSSH format). This can be done at boot (e.g., as part of rc.local) allowing
        /// for secure access without passwords.
        ///
        /// Optional user data can be provided in the launch request. All instances that
        /// collectively comprise the launch request have access to this data.
        /// For more information, go the Amazon Elastic Compute Cloud Developer
        /// Guide.
        ///
        /// Note - if any of the AMIs have a product code attached for
        /// which the user has not subscribed, the RunInstances call will fail.
        ///
        /// Important - we strongly recommend using the 2.6.18 Xen stock
        /// kernel with High-CPU and High-Memory instances. Although the
        /// default Amazon EC2 kernels will work, the new kernels provide
        /// greater stability and performance for these instance types. For more
        /// information about kernels, go the Amazon Elastic Compute Cloud Developer Guide
        /// </remarks>
        /// <param name="request">Run Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Run Instances  Response from the service</returns>
        public RunInstancesResponse RunInstances(RunInstancesRequest request)
        {
            return Invoke<RunInstancesResponse>(ConvertRunInstances(request), RunInstancesResponse.serializer_UnknownElement);
        }

        /// <summary>
        /// Stops an Amazon EBS-backed instance.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Each time you transition an instance from stopped to started,
        /// we charge a full instance hour, even if transitions happen multiple
        /// times within a single hour.
        /// </para>
        /// <para>
        /// Although Spot Instances can use Amazon EBS-backed AMIs, they don't
        /// support Stop/Start. In other words, you can't stop and start Spot
        /// Instances launched from an AMI with an Amazon EBS root device.
        /// </para>
        /// <para>
        /// Instances that use Amazon EBS volumes as their root devices can be
        /// quickly stopped and started. When an instance is stopped, the compute
        /// resources are released and you are not billed for hourly instance usage.
        /// However, your root partition Amazon EBS volume remains, continues to
        /// persist your data, and you are charged for Amazon EBS volume usage.
        /// You can restart your instance at any time.
        /// </para>
        /// <para>
        /// Before stopping an instance, make sure it is in a state from which it
        /// can be restarted. Stopping an instance does not preserve data stored
        /// in RAM. Performing this operation on an instance that uses an instance
        /// store as its root device returns an error.
        /// </para>
        /// <para>
        /// You can stop, start, and terminate EBS-backed instances. You can only
        /// terminate S3-backed instances. What happens to an instance differs
        /// if you stop it or terminate it. For example, when you stop an instance,
        /// the root device and any other devices attached to the instance persist.
        /// When you terminate an instance, the root device and any other devices
        /// attached during the instance launch are automatically deleted.
        /// </para>
        /// </remarks>
        /// <param name="request">Stop Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Stop Instances  Response from the service</returns>
        public StopInstancesResponse StopInstances(StopInstancesRequest request)
        {
            return Invoke<StopInstancesResponse>(ConvertStopInstances(request));
        }

        /// <summary>
        /// Starts an Amazon EBS-backed AMI that you've previously stopped.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instances that use Amazon EBS volumes as their root devices can be quickly
        /// stopped and started. When an instance is stopped, the compute resources are
        /// released and you are not billed for hourly instance usage. However, your
        /// root partition Amazon EBS volume remains, continues to persist your data, and
        /// you are charged for Amazon EBS volume usage. You can restart your instance
        /// at any time. Each time you transition an instance from stopped to started,
        /// we charge a full instance hour, even if transitions happen multiple times
        /// within a single hour.
        /// </para>
        /// <para>
        /// Before stopping an instance, make sure it is in a state from which it can
        /// be restarted. Stopping an instance does not preserve data stored in RAM.
        /// </para>
        /// <para>
        /// Performing this operation on an instance that uses an instance store as its root device returns
        /// an error.
        /// </para>
        /// </remarks>
        /// <param name="request">Start Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Start Instances  Response from the service</returns>
        public StartInstancesResponse StartInstances(StartInstancesRequest request)
        {
            return Invoke<StartInstancesResponse>(ConvertStartInstances(request));
        }

        /// <summary>
        /// Modifies an attribute of an instance.
        /// </summary>
        /// <param name="request">Modify Instance Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Instance Attribute  Response from the service</returns>
        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            return Invoke<ModifyInstanceAttributeResponse>(ConvertModifyInstanceAttribute(request));
        }

        /// <summary>
        /// Resets an attribute of an instance to its default value.
        /// </summary>
        /// <param name="request">Reset Instance Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reset Instance Attribute  Response from the service</returns>
        public ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request)
        {
            return Invoke<ResetInstanceAttributeResponse>(ConvertResetInstanceAttribute(request));
        }

        /// <summary>
        /// Gets information about an attribute of an instance.
        /// Only one attribute can be specified per call.
        /// </summary>
        /// <param name="request">Describe Instance Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Instance Attribute  Response from the service</returns>
        public DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            return Invoke<DescribeInstanceAttributeResponse>(ConvertDescribeInstanceAttribute(request));
        }

        /// <summary>
        /// Shuts down one or more instances.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This operation is idempotent; if you terminate an instance more than
        /// once, each call will succeed. Terminated instances will remain visible
        /// after termination (approximately one hour).
        /// </para>
        /// <para>
        /// By default, Amazon EC2 deletes all Amazon EBS volumes that were attached
        /// when the instance launched. Amazon EBS volumes attached after instance
        /// launch continue running.
        /// </para>
        /// <para>
        /// You can stop, start, and terminate EBS-backed instances. You can only
        /// terminate S3-backed instances. What happens to an instance differs if
        /// you stop it or terminate it. For example, when you stop an instance,
        /// the root device and any other devices attached to the instance persist.
        /// When you terminate an instance, the root device and any other devices
        /// attached during the instance launch are automatically deleted.
        /// </para>
        /// </remarks>
        /// <param name="request">Terminate Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Terminate Instances  Response from the service</returns>
        public TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request)
        {
            return Invoke<TerminateInstancesResponse>(ConvertTerminateInstances(request));
        }

        /// <summary>
        /// Enables monitoring for a running instance.
        /// </summary>
        /// <param name="request">Monitor Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Monitor Instances  Response from the service</returns>
        public MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request)
        {
            return Invoke<MonitorInstancesResponse>(ConvertMonitorInstances(request));
        }

        /// <summary>
        /// Disables monitoring for a running instance.
        /// </summary>
        /// <param name="request">Unmonitor Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Unmonitor Instances  Response from the service</returns>
        public UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request)
        {
            return Invoke<UnmonitorInstancesResponse>(ConvertUnmonitorInstances(request));
        }

        /// <summary>
        /// Gives you information about your VPN connections.
        ///
        /// Important - we strongly recommend you use HTTPS when calling this
        /// operation because the response contains sensitive cryptographic
        /// information for configuring your customer gateway.
        ///
        /// You can filter the results to return information only about VPN
        /// connections that match criteria you specify.
        ///
        /// For example, you could ask to get information about a particular VPN
        /// connection (or all) only if the VPN's state is pending or available.
        ///
        /// You can specify multiple filters (e.g., the VPN connection is
        /// associated with a particular VPN gateway, and
        /// the gateway's state is pending or available).
        ///
        /// The result includes information for a particular VPN connection
        /// only if the VPN connection matches all your filters.
        ///
        /// If there's no match, no special message is returned; the response is
        /// simply empty.
        ///
        /// The returned information consists of:
        /// 1. The VPN connection ID.
        /// 2. The type of connection.
        /// 3. Customer gateway ID.
        /// 4. VPN gateway ID.
        /// 5. The current state of the VPN connection (pending, available,
        /// deleting, deleted).
        /// 6. The customer gateway configuration information in the
        /// native XML format.
        /// </summary>
        /// <param name="request">Describe Vpn Connections  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Vpn Connections  Response from the service</returns>
        public DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request)
        {
            return Invoke<DescribeVpnConnectionsResponse>(ConvertDescribeVpnConnections(request));
        }

        /// <summary>
        /// Gives you information about your subnets.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information only about
        /// subnets that match criteria you specify.
        /// For example, you could ask to get information about a particular
        /// subnet (or all) only if the subnet's state is available.
        /// You can specify multiple filters (e.g., the subnet is in a
        /// particular VPC, and the subnet's state is available).
        ///
        /// The result includes information for a particular subnet
        /// only if the subnet matches all your filters. If there's
        /// no match, no special message is returned; the response
        /// is simply empty
        /// </remarks>
        /// <param name="request">Describe Subnets  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Subnets  Response from the service</returns>
        public DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request)
        {
            return Invoke<DescribeSubnetsResponse>(ConvertDescribeSubnets(request));
        }

        /// <summary>
        /// Detaches a VPN gateway from a VPC.
        /// </summary>
        /// <remarks>
        /// You do this if you're planning to turn off the VPC and
        /// not use it anymore. You can confirm a VPN gateway has
        /// been completely detached from a VPC by describing the
        /// VPN gateway (any attachments to the VPN gateway are
        /// also described).
        ///
        /// You must wait for the attachment's state to switch
        /// to detached before you can delete the VPC
        /// or attach a different VPC to the VPN gateway.
        /// </remarks>
        /// <param name="request">Detach Vpn Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Detach Vpn Gateway  Response from the service</returns>
        public DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request)
        {
            return Invoke<DetachVpnGatewayResponse>(ConvertDetachVpnGateway(request));
        }

        /// <summary>
        /// Gives you information about your VPCs.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information only
        /// about VPCs that match criteria you specify.
        ///
        /// For example, you could ask to get information about a
        /// particular VPC or VPCs (or all your VPCs) only if the
        /// VPC's state is available.
        ///
        /// You can specify multiple filters (e.g., the VPC uses
        /// one of several sets of DHCP options, and the VPC's
        /// state is available).
        ///
        /// The result includes information for a particular VPC
        /// only if the VPC matches all your filters.
        ///
        /// If there's no match, no special message is returned;
        /// the response is simply empty.
        ///
        /// The information returned consists of:
        /// a) The VPC ID.
        /// b) The CIDR block
        /// you've assigned to the VPC.
        /// c) The ID of the DHCP options you've associated with the VPC
        /// (or "default" if the default options are associated with the VPC)
        ///
        /// The current state of the VPC (pending or available)
        /// </remarks>
        /// <param name="request">Describe Vpcs  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Vpcs  Response from the service</returns>
        public DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            return Invoke<DescribeVpcsResponse>(ConvertDescribeVpcs(request));
        }

        /// <summary>
        /// Deletes a customer gateway.
        /// </summary>
        /// <remarks>
        /// You must delete the VPN connection before deleting
        /// the customer gateway.
        ///
        /// AWS might delete any customer gateway if you leave
        /// it inactive for an extended period of time (inactive
        /// means that there's no VPN connection in use with the
        /// customer gateway).
        /// </remarks>
        /// <param name="request">Delete Customer Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Customer Gateway  Response from the service</returns>
        public DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request)
        {
            return Invoke<DeleteCustomerGatewayResponse>(ConvertDeleteCustomerGateway(request));
        }

        /// <summary>
        /// Attaches a virtual private gateway to a VPC.
        /// </summary>
        /// <remarks>
        /// This is the last step required to get your VPC fully connected
        /// to your data center before launching instances in it.
        /// </remarks>
        /// <param name="request">Attach Vpn Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Attach Vpn Gateway  Response from the service</returns>
        public AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request)
        {
            return Invoke<AttachVpnGatewayResponse>(ConvertAttachVpnGateway(request));
        }

        /// <summary>
        /// Deletes a set of DHCP options that you specify.
        /// </summary>
        /// <remarks>
        /// Amazon VPC returns an error if the set of options
        /// you specify is currently associated with a VPC.
        /// You can disassociate the set of options by associating
        /// either a new set of options or the default options
        /// with the VPC.
        /// </remarks>
        /// <param name="request">Delete Dhcp Options  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Dhcp Options  Response from the service</returns>
        public DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request)
        {
            return Invoke<DeleteDhcpOptionsResponse>(ConvertDeleteDhcpOptions(request));
        }

        /// <summary>
        /// Deletes a subnet from a VPC.
        /// </summary>
        /// <remarks>
        /// You must terminate all running instances in the subnet
        /// before deleting it, otherwise Amazon VPC returns an error.
        ///
        /// AWS might delete any subnet if you leave it inactive for
        /// an extended period of time (inactive means that there are
        /// no running Amazon EC2 instances in the subnet).
        /// </remarks>
        /// <param name="request">Delete Subnet  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Subnet  Response from the service</returns>
        public DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request)
        {
            return Invoke<DeleteSubnetResponse>(ConvertDeleteSubnet(request));
        }

        /// <summary>
        /// Creates a VPC with the CIDR block you specify.
        /// </summary>
        /// <remarks>
        /// The smallest VPC you can create uses a /28 netmask (16 IP
        /// addresses), and the largest uses a /18 netmask (16,384 IP addresses).
        /// To help you decide how big to make your VPC, go to the
        /// topic about creating VPCs in the Amazon Virtual Private Cloud
        /// Developer Guide.
        ///
        /// By default, each instance you launch in the VPC has the default DHCP
        /// options (the standard EC2 host name, no domain name, no DNS server, no NTP
        /// server, and no NetBIOS server or node type).
        ///
        /// AWS might delete any VPC that you create with this operation
        /// if you leave it inactive for an extended period of time (inactive
        /// means that there are no running Amazon EC2 instances in the VPC).
        /// </remarks>
        /// <param name="request">Create Vpc  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Vpc  Response from the service</returns>
        public CreateVpcResponse CreateVpc(CreateVpcRequest request)
        {
            return Invoke<CreateVpcResponse>(ConvertCreateVpc(request));
        }

        /// <summary>
        /// Provides information to AWS about your customer gateway device.
        /// </summary>
        /// <remarks>
        /// The customer gateway is the appliance at your end of the VPN connection
        /// (compared to the VPN gateway, which is the device at the AWS side of the
        /// VPN connection). AWS might delete any customer gateway that you create
        /// with this operation if you leave it inactive for an extended period of
        /// time (inactive means that there's no VPN connection in use with the customer
        /// gateway).
        ///
        /// You must provide the Internet-routable IP address of the customer
        /// gateway's external interface. The IP address must be static and can't be
        /// behind a device performing network address translation (NAT).
        ///
        /// For device’s that use Border Gateway Protocal (BGP), you can also provide the 
        /// device's Border Gateway Protocol (BGP) Autonomous System Number (ASN). You can 
        /// use an existing ASN assigned to your network. If you don't have an ASN already, 
        /// you can use a private ASN (in the 64512 - 65534 range).
        /// 
        /// Amazon EC2 supports all 2-byte ASN numbers in the range of 1 - 65534, with the 
        /// exception of 7224, which is reserved in US East, and 9059, which is reserved in 
        /// EU West
        /// 
        /// For more information about ASNs, go to the Wikipedia article -
        /// http://en.wikipedia.org/wiki/Autonomous_system_%28Internet%29.
        /// </remarks>
        /// <param name="request">Create Customer Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Customer Gateway  Response from the service</returns>
        public CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request)
        {
            return Invoke<CreateCustomerGatewayResponse>(ConvertCreateCustomerGateway(request));
        }

        /// <summary>
        /// Creates a new VPN gateway.
        /// </summary>
        /// <remarks>
        /// A VPN gateway is the VPC-side endpoint for your VPN
        /// connection. You can create a VPN gateway before
        /// creating the VPC itself. AWS might delete any VPN
        /// gateway that you create with this operation if you leave
        /// it inactive for an extended period of time (inactive means that
        /// there's no VPN connection in use with the VPN gateway)
        /// </remarks>
        /// <param name="request">Create Vpn Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Vpn Gateway  Response from the service</returns>
        public CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request)
        {
            return Invoke<CreateVpnGatewayResponse>(ConvertCreateVpnGateway(request));
        }

        /// <summary>
        /// Deletes a VPC.
        /// </summary>
        /// <remarks>
        /// You must terminate all running instances and delete
        /// all subnets before deleting the VPC, otherwise Amazon
        /// VPC returns an error.
        ///
        /// AWS might delete any VPC if you leave it inactive for
        /// an extended period of time (inactive means that there
        /// are no running Amazon EC2 instances in the VPC).
        /// </remarks>
        /// <param name="request">Delete Vpc  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Vpc  Response from the service</returns>
        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
        {
            return Invoke<DeleteVpcResponse>(ConvertDeleteVpc(request));
        }

        /// <summary>
        /// Associates a set of DHCP options (that you've previously created) with the
        /// specified VPC. Or, associates the default DHCP options with the VPC.
        /// </summary>
        /// <remarks>
        /// The default set consists of the standard EC2 host name, no domain name, no
        /// DNS server, no NTP server, and no NetBIOS server or node type.
        ///
        /// After you associate the options with the VPC, any existing instances
        /// and all new instances that you launch in that VPC use the options. For more
        /// information about the supported DHCP options and using them with
        /// Amazon VPC, go to Using DHCP Options in the Amazon Virtual Private Cloud
        /// Developer Guide.
        /// </remarks>
        /// <param name="request">Associate Dhcp Options  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Associate Dhcp Options  Response from the service</returns>
        public AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request)
        {
            return Invoke<AssociateDhcpOptionsResponse>(ConvertAssociateDhcpOptions(request));
        }

        /// <summary>
        /// Gives you information about your VPN gateways.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information
        /// only about VPN gateways that match criteria you specify. For example,
        /// you could ask to get information about a particular VPN gateway (or all) only
        /// if the gateway's state is pending or available. You can specify
        /// multiple filters (e.g., the VPN gateway is in a particular
        /// Availability Zone and the gateway's state is pending or available).
        /// The result includes information for a particular VPN gateway only if
        /// the gateway matches all your filters. If there's no match, no
        /// special message is returned; the response is simply empty.
        ///
        /// The returned information consists of:
        ///
        /// 1. The VPN gateway ID - The current state of the VPN gateway
        /// (pending, available, deleting, deleted)
        /// 2. The type of VPN connection the VPN gateway supports.
        /// 3. The Availability Zone where the VPN gateway was created.
        /// 4. The VPCs the VPN gateway is attached to and the state of each
        /// attachment (attaching, attached, detaching, detached)
        /// </remarks>
        /// <param name="request">Describe Vpn Gateways  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Vpn Gateways  Response from the service</returns>
        public DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request)
        {
            return Invoke<DescribeVpnGatewaysResponse>(ConvertDescribeVpnGateways(request));
        }

        /// <summary>
        /// Creates a subnet in an existing VPC.
        /// </summary>
        /// <remarks>
        /// You can create up to 20 subnets in a VPC. If you add more than one subnet to a
        /// VPC, they're set up in a star topology with a logical router in the middle.
        /// If you feel you need more than 20 subnets, you can request more by going
        /// to http://aws.amazon.com/contact-us/vpc-request/.
        /// 
        /// When you create each subnet, you provide the VPC ID and the CIDR block you
        /// want for the subnet. Once you create a subnet, you can't change its CIDR block.
        /// The subnet's CIDR block can be the same as the VPC's CIDR block (assuming you
        /// want only a single subnet in the VPC), or a subset of the VPC's CIDR block. If you
        /// create more than one subnet in a VPC, the subnets' CIDR blocks must not overlap.
        /// The smallest subnet (and VPC) you can create uses a /28 netmask (16 IP
        /// addresses), and the largest uses a /18 netmask (16,384 IP addresses).
        ///
        /// *Important*
        ///
        /// AWS reserves both the first four and the last IP address in each subnet's CIDR block.
        /// They're not available for use.
        ///
        /// AWS might delete any subnet you create with this operation if you leave it inactive
        /// for an extended period of time (inactive means that there are no running Amazon
        /// EC2 instances in the subnet).
        /// </remarks>
        /// <param name="request">Create Subnet  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Subnet  Response from the service</returns>
        public CreateSubnetResponse CreateSubnet(CreateSubnetRequest request)
        {
            return Invoke<CreateSubnetResponse>(ConvertCreateSubnet(request));
        }

        /// <summary>
        /// Deletes a VPN connection.
        /// </summary>
        /// <remarks>
        /// This operation will delete a VPC and all its associated components.
        /// Another reason to use this operation is if you believe the tunnel
        /// credentials for your VPN connection have been compromised.
        ///
        /// In that situation, you can delete the VPN connection and create a
        /// new one that has new keys, without needing to delete
        /// the VPC or VPN gateway. If you create a new VPN
        /// connection, you must reconfigure the customer
        /// gateway using the new configuration information returned
        /// with the new VPN connection ID.
        ///
        /// If you're deleting the VPC and all its associated parts, we
        /// recommend you detach the VPN gateway from the
        /// VPC and delete the VPC before deleting the VPN
        /// connection.
        /// </remarks>
        /// <param name="request">Delete Vpn Connection  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Vpn Connection  Response from the service</returns>
        public DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request)
        {
            return Invoke<DeleteVpnConnectionResponse>(ConvertDeleteVpnConnection(request));
        }

        /// <summary>
        /// Deletes a VPN gateway.
        /// </summary>
        /// <remarks>
        /// Use this when you want to delete a VPC and all its
        /// associated components because you no longer need them. We recommend
        /// that before you delete a VPN gateway, you detach it from the VPC
        /// and delete the VPN connection. Note that you don't need to delete
        /// the VPN gateway if you just want to delete and re-create the VPN
        /// connection between your VPC and data center.
        ///
        /// AWS might delete any VPN gateway if you leave it inactive for an
        /// extended period of time (inactive means that there's no VPN
        /// connection in use with the VPN gateway).
        /// </remarks>
        /// <param name="request">Delete Vpn Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Vpn Gateway  Response from the service</returns>
        public DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request)
        {
            return Invoke<DeleteVpnGatewayResponse>(ConvertDeleteVpnGateway(request));
        }

        /// <summary>
        /// Returns information about your customer gateways.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information only about customer gateways
        /// that match criteria you specify.
        /// 
        /// For example, you could ask to get information about a particular
        /// customer gateway (or all) only if the gateway's state is pending or
        /// available. You can specify multiple filters (e.g., the customer
        /// gateway has a particular IP address for the Internet-routable
        /// external interface, and the gateway's state is pending or
        /// available). The result includes information for a particular
        /// customer gateway only if the gateway matches all your
        /// filters. If there's no match, no special message is returned;
        /// the response is simply empty
        /// </remarks>
        /// <param name="request">Describe Customer Gateways  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Customer Gateways  Response from the service</returns>
        public DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
        {
            return Invoke<DescribeCustomerGatewaysResponse>(ConvertDescribeCustomerGateways(request));
        }

        /// <summary>
        /// Creates a VPN connection between an existing virtual private gateway and a VPN customer gateway.
        /// The only supported connection type is ipsec.1.
        /// </summary>
        /// <remarks>
        /// The response includes information that you need to configure your customer gateway, in XML format.
        /// 
        /// It is strongly recommend that you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway.
        /// If you shut down your VPN connection for any reason and later create a new VPN connection, you must
        /// reconfigure your customer gateway with the new information returned from CreateVpnConnection.
        /// </remarks>
        /// <param name="request">Create Vpn Connection  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Vpn Connection  Response from the service</returns>
        public CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request)
        {
            return Invoke<CreateVpnConnectionResponse>(ConvertCreateVpnConnection(request));
        }

        /// <summary>
        /// Gives you information about one or more sets of DHCP options. You can
        /// specify one or more DHCP options set IDs, or no IDs (to describe
        /// all your sets of DHCP options).
        /// </summary>
        /// <remarks>
        /// The returned information consists of:
        /// 1. The DHCP options set ID
        /// 2. The options
        /// </remarks>
        /// <param name="request">Describe Dhcp Options  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Dhcp Options  Response from the service</returns>
        public DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request)
        {
            return Invoke<DescribeDhcpOptionsResponse>(ConvertDescribeDhcpOptions(request));
        }

        /// <summary>
        /// Creates a set of DHCP options that you can then associate with one or more VPCs, causing all
        /// existing and new instances that you launch in those VPCs to use the set of DHCP options.
        /// </summary>
        /// <remarks>
        /// The following are DHCP options you can specify.
        ///
        /// Options:
        /// 1. domain-name
        /// A domain name of your choice (e.g., mydomain.com).
        ///
        /// 2. domain-name-servers
        /// The IP address of a domain name server (e.g., 10.2.5.1).
        /// You can specify up to four addresses.
        ///
        /// 3. ntp-servers
        /// The IP address of a Network Time Protocol (NTP)
        /// server (e.g., 10.4.6.1). You can specify up to four addresses.
        ///
        /// 4. netbios-name-servers
        /// The IP address of a NetBIOS name server (e.g., 10.8.9.5).
        /// You can specify up to four addresses.
        ///
        /// 5. netbios-node-type
        /// Value indicating the NetBIOS node type (1, 2, 4, or 8).
        /// </remarks>
        /// <param name="request">Create Dhcp Options  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Dhcp Options  Response from the service</returns>
        public CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request)
        {
            return Invoke<CreateDhcpOptionsResponse>(ConvertCreateDhcpOptions(request));
        }

        /// <summary>
        /// Creates a Spot Instance request.
        /// </summary>
        /// <remarks>
        /// Spot Instances are instances that Amazon EC2 starts on your behalf
        /// when the maximum price that you specify exceeds the current Spot Price.
        /// Amazon EC2 periodically sets the Spot Price based on available
        /// Spot Instance capacity and current Spot Instance requests.
        /// </remarks>
        /// <param name="request">Request Spot Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Request Spot Instances  Response from the service</returns>
        public RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request)
        {
            return Invoke<RequestSpotInstancesResponse>(ConvertRequestSpotInstances(request));
        }

        /// <summary>
        /// Describes the Spot Instance requests that belong to your account.
        /// </summary>
        /// <remarks>
        /// Spot Instances are instances that automatically launch
        /// when your request price exceeds that Spot Price
        /// that Amazon EC2 periodically calculates.
        /// </remarks>
        /// <param name="request">Describe Spot Instance Requests  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Spot Instance Requests  Response from the service</returns>
        public DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request)
        {
            return Invoke<DescribeSpotInstanceRequestsResponse>(ConvertDescribeSpotInstanceRequests(request));
        }

        /// <summary>
        /// Cancels one or more Spot Instance requests.
        /// </summary>
        /// <remarks>
        /// Spot Instances are instances that Amazon EC2 starts on your behalf when the
        /// maximum price that you specify exceeds the current Spot Price.
        /// Amazon EC2 periodically sets the Spot Price based on available Spot Instance
        /// capacity and current Spot Instance requests.
        /// </remarks>
        /// <param name="request">Cancel Spot Instance Requests  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Cancel Spot Instance Requests  Response from the service</returns>
        public CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request)
        {
            return Invoke<CancelSpotInstanceRequestsResponse>(ConvertCancelSpotInstanceRequests(request));
        }

        /// <summary>
        /// Describes the Spot Price history.
        /// </summary>
        /// <param name="request">Describe Spot Price History  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Spot Price History  Response from the service</returns>
        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
        {
            return Invoke<DescribeSpotPriceHistoryResponse>(ConvertDescribeSpotPriceHistory(request));
        }

        /// <summary>
        /// Creates the datafeed for Spot Instances, enabling you to view Spot Instance usage logs.
        /// You can create one data feed per account.
        /// </summary>
        /// <param name="request">Create Spot Datafeed Subscription  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Spot Datafeed Subscription  Response from the service</returns>
        public CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request)
        {
            return Invoke<CreateSpotDatafeedSubscriptionResponse>(ConvertCreateSpotDatafeedSubscription(request));
        }

        /// <summary>
        /// Describes the datafeed for Spot Instances.
        /// </summary>
        /// <param name="request">Describe Spot Datafeed Subscription  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Spot Datafeed Subscription  Response from the service</returns>
        public DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request)
        {
            return Invoke<DescribeSpotDatafeedSubscriptionResponse>(ConvertDescribeSpotDatafeedSubscription(request));
        }

        /// <summary>
        /// Deletes the datafeed for Spot Instances.
        /// </summary>
        /// <param name="request">Delete Spot Datafeed Subscription  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Spot Datafeed Subscription  Response from the service</returns>
        public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request)
        {
            return Invoke<DeleteSpotDatafeedSubscriptionResponse>(ConvertDeleteSpotDatafeedSubscription(request));
        }

        /// <summary>
        /// Cancels an active conversion task.
        /// The task can be the import of an instance or volume.
        /// </summary>
        /// <remarks>
        /// The command removes all artifacts of the conversion, including a partially uploaded volume or instance.
        /// If the conversion is complete or is in the process of transferring the final disk image,
        /// the command fails and returns an exception.
        /// </remarks>
        /// <param name="request">Cancel Conversion Task  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Cancel Conversion Task  Response from the service</returns>
        public CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request)
        {
            return Invoke<CancelConversionTaskResponse>(ConvertCancelConversionTask(request));
        }

        /// <summary>
        /// Describes your conversion tasks.
        /// For more information, go to Importing Your Virtual Machines and Volumes into Amazon EC2 in the Amazon Elastic Compute Cloud User Guide.
        /// </summary>
        /// <param name="request">Describe Conversion Tasks  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Conversion Tasks  Response from the service</returns>
        public DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request)
        {
            return Invoke<DescribeConversionTasksResponse>(ConvertDescribeConversionTasks(request));
        }

        /// <summary>
        /// Creates a new import instance task using metadata from the specified disk image.
        /// </summary>
        /// <param name="request">Import Instance  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Import Instance  Response from the service</returns>
        public ImportInstanceResponse ImportInstance(ImportInstanceRequest request)
        {
            return Invoke<ImportInstanceResponse>(ConvertImportInstance(request));
        }

        /// <summary>
        /// Creates a new import volume task using metadata from the specified disk image.
        /// </summary>
        /// <param name="request">Import Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Import Volume  Response from the service</returns>
        public ImportVolumeResponse ImportVolume(ImportVolumeRequest request)
        {
            return Invoke<ImportVolumeResponse>(ConvertImportVolume(request));
        }

        /// <summary>
        /// Adds one or more egress rules to a VPC security group.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This call permits instances in a security group to send traffic to one or more destination
        /// CIDR IP address ranges, or to one or more destination security groups in the same VPC.
        /// </para>
        /// <para>
        /// This action applies only to security groups in a VPC; it's not supported for standard (EC2) security groups.
        /// </para>
        /// <para>
        /// Each rule consists of the protocol (e.g., TCP), plus either a CIDR range, or a source group. For the TCP
        /// and UDP protocols, you must also specify the destination port or port range. For the ICMP protocol, you
        /// must also specify the ICMP type and code.You can use -1 as a wildcard for the ICMP type or code.
        /// </para>
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible. However, a
        /// small delay might occur.
        /// </para>
        /// </remarks>
        /// <param name="request">Authorize Security Group Egress  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Authorize Security Group Egress  Response from the service</returns>
        public AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            return Invoke<AuthorizeSecurityGroupEgressResponse>(ConvertAuthorizeSecurityGroupEgress(request));
        }

        /// <summary>
        /// Removes one or more egress rules from a VPC security group. 
        /// </summary>
        /// <remarks>
        /// This action applies only to security groups in a VPC. It doesn't work with standard (EC2) security groups.
        /// For information about Amazon Virtual Private Cloud and VPC security groups, go to the Amazon Virtual
        /// Private Cloud User Guide.
        /// 
        /// The values that you specify in the revoke request (e.g., ports, etc.) must match the existing rule's values
        /// in order for the rule to be revoked.
        /// 
        /// Each rule consists of the protocol, and the CIDR range or destination security group. For the TCP and
        /// UDP protocols, you must also specify the destination port or range of ports. For the ICMP protocol, you
        /// must also specify the ICMP type and code.
        /// 
        /// Rule changes are propagated to instances within the security group as quickly as possible. However, a
        /// small delay might occur.
        /// </remarks>
        /// <param name="request">Revoke Security Group Egress  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Revoke Security Group Egress  Response from the service</returns>
        public RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            return Invoke<RevokeSecurityGroupEgressResponse>(ConvertRevokeSecurityGroupEgress(request));
        }

        /// <summary>
        /// Creates a new Internet gateway in your AWS account. After creating the Internet gateway, you attach
        /// it to a VPC using AttachInternetGateway.
        /// </summary>
        /// <param name="request">Create Internet Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Internet Gateway  Response from the service</returns>
        public CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request)
        {
            return Invoke<CreateInternetGatewayResponse>(ConvertCreateInternetGateway(request));
        }

        /// <summary>
        /// Gives you information about your Internet gateways.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information only
        /// about Internet gateways that match criteria you specify.
        /// For example, you could get information only
        /// about gateways with particular tags.
        /// The Internet gateway must match at least one of the specified values
        /// for it to be included in the results.
        /// 
        /// You can specify multiple filters (e.g., the Internet gateway is
        /// attached to a particular VPC and is tagged with a particular value).
        /// The result includes information for a particular Internet gateway
        /// only if the gateway matches all your filters.
        /// 
        /// If there's no match, no special message is returned; the response is simply empty.
        /// 
        /// You can use wildcards with the filter values:
        /// * matches zero or more characters, and ? matches exactly one character.
        /// 
        /// You can escape special characters using a backslash before the character. For example,
        /// a value of \*amazon\?\\ searches for the literal string *amazon?\.
        /// </remarks>
        /// <param name="request">Describe Internet Gateways  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Internet Gateways  Response from the service</returns>
        public DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request)
        {
            return Invoke<DescribeInternetGatewaysResponse>(ConvertDescribeInternetGateways(request));
        }

        /// <summary>
        /// Deletes an Internet gateway from your AWS account. The gateway must not be attached to a VPC. For
        /// more information about your VPC and Internet gateway, go to Amazon Virtual Private Cloud User Guide.
        /// </summary>
        /// <param name="request">Delete Internet Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Internet Gateway  Response from the service</returns>
        public DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request)
        {
            return Invoke<DeleteInternetGatewayResponse>(ConvertDeleteInternetGateway(request));
        }

        /// <summary>
        /// Attaches an Internet gateway to a VPC, enabling connectivity between the Internet and the VPC.
        /// </summary>
        /// <param name="request">Attach Internet Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Attach Internet Gateway  Response from the service</returns>
        public AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request)
        {
            return Invoke<AttachInternetGatewayResponse>(ConvertAttachInternetGateway(request));
        }

        /// <summary>
        /// Detaches an Internet gateway from a VPC, disabling connectivity
        /// between the Internet and the VPC.
        /// </summary>
        /// <remarks>
        /// The VPC must not contain any running instances with elastic IP
        /// addresses. For more information about your VPC and Internet gateway,
        /// go to Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Detach Internet Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Detach Internet Gateway  Response from the service</returns>
        public DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request)
        {
            return Invoke<DetachInternetGatewayResponse>(ConvertDetachInternetGateway(request));
        }

        /// <summary>
        /// Creates a route table within a VPC.
        /// After you create a new route table, you can add routes and associate the table with a subnet.
        /// </summary>
        /// <param name="request">Create Route Table  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Route Table  Response from the service</returns>
        public CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request)
        {
            return Invoke<CreateRouteTableResponse>(ConvertCreateRouteTable(request));
        }

        /// <summary>
        /// Gives you information about your route tables.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information only about
        /// tables that match criteria you specify. For example, you
        /// could get information only about a table associated with a
        /// particular subnet.You can specify multiple values for the filter.
        /// The table must match at least one of the specified values for
        /// it to be included in the results.
        /// 
        /// You can specify multiple filters (e.g., the table has a
        /// particular route, and is associated with a particular subnet).
        /// The result includes information for a particular table only if
        /// it matches all your filters. If there's no match, no special
        /// message is returned; the response is simply empty.
        /// 
        /// You can use wildcards with the filter values: * matches zero or
        /// more characters, and ? matches exactly one character.
        /// You can escape special characters using a backslash before the
        /// character. For example, a value of \*amazon\?\\ searches for the
        /// literal string *amazon?\.
        /// </remarks>
        /// <param name="request">Describe Route Tables  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Route Tables  Response from the service</returns>
        public DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request)
        {
            return Invoke<DescribeRouteTablesResponse>(ConvertDescribeRouteTables(request));
        }

        /// <summary>
        /// Deletes a route table from a VPC. The route table must not be associated with a subnet.
        /// You can't delete the main route table.
        /// </summary>
        /// <param name="request">Delete Route Table  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Route Table  Response from the service</returns>
        public DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request)
        {
            return Invoke<DeleteRouteTableResponse>(ConvertDeleteRouteTable(request));
        }

        /// <summary>
        /// Associates a subnet with a route table.
        /// </summary>
        /// <remarks>
        /// The subnet and route table must be in the same VPC. This
        /// association causes traffic originating from the subnet
        /// to be routed according to the routes in the route table.
        /// The action returns an association ID, which you need if
        /// you want to disassociate the route table from the subnet
        /// later. A route table can be associated with multiple subnets.
        /// </remarks>
        /// <param name="request">Associate Route Table  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Associate Route Table  Response from the service</returns>
        public AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request)
        {
            return Invoke<AssociateRouteTableResponse>(ConvertAssociateRouteTable(request));
        }

        /// <summary>
        /// Changes the route table associated with a given subnet in a VPC.
        /// </summary>
        /// <remarks>
        /// After you execute this action, the subnet uses the routes in the
        /// new route table it's associated with. For more information about
        /// route tables, go to Route Tables in the Amazon Virtual Private
        /// Cloud User Guide.
        /// </remarks>
        /// <param name="request">Replace Route Table Association  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Replace Route Table Association  Response from the service</returns>
        public ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request)
        {
            return Invoke<ReplaceRouteTableAssociationResponse>(ConvertReplaceRouteTableAssociation(request));
        }

        /// <summary>
        /// Disassociates a subnet from a route table.
        /// </summary>
        /// <remarks>
        /// After you perform this action, the subnet no longer
        /// uses the routes in the route table. Instead it uses
        /// the routes in the VPC's main route table.
        /// For more information about route tables, go to Route
        /// Tables in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Disassociate Route Table  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Disassociate Route Table  Response from the service</returns>
        public DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request)
        {
            return Invoke<DisassociateRouteTableResponse>(ConvertDisassociateRouteTable(request));
        }

        /// <summary>
        /// Creates a new route in a route table within a VPC.
        /// The route's target can be either a gateway attached
        /// to the VPC or a NAT instance in the VPC.
        /// </summary>
        /// <remarks>
        /// When determining how to route traffic, we use the route
        /// with the most specific match. For example, let's say the
        /// traffic is destined for 192.0.2.3, and the route table
        /// includes the following two routes:
        /// 192.0.2.0/24 (goes to some target A)
        /// 192.0.2.0/28 (goes to some target B)
        /// 
        /// Both routes apply to the traffic destined for 192.0.2.3.
        /// However, the second route in the list is more specific,
        /// so we use that route to determine where to target the traffic.
        /// 
        /// For more information about route tables, go to Route
        /// Tables in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Create Route  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Route  Response from the service</returns>
        public CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            return Invoke<CreateRouteResponse>(ConvertCreateRoute(request));
        }

        /// <summary>
        /// Replaces an existing route within a route table in a VPC.
        /// </summary>
        /// <remarks>
        /// For more information about route tables, go to Route Tables
        /// in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Replace Route  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Replace Route  Response from the service</returns>
        public ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request)
        {
            return Invoke<ReplaceRouteResponse>(ConvertReplaceRoute(request));
        }

        /// <summary>
        /// Deletes a route from a route table in a VPC.
        /// </summary>
        /// <param name="request">Delete Route  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Route  Response from the service</returns>
        public DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            return Invoke<DeleteRouteResponse>(ConvertDeleteRoute(request));
        }

        /// <summary>
        /// Creates a network ACL in a VPC.
        /// </summary>
        /// <remarks>
        /// Network ACLs provide an optional layer of security (on top of security groups)
        /// for the instances in your VPC.
        /// </remarks>
        /// <param name="request">Create Network Acl  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Network Acl  Response from the service</returns>
        public CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request)
        {
            return Invoke<CreateNetworkAclResponse>(ConvertCreateNetworkAcl(request));
        }

        /// <summary>
        /// Gives you information about the network ACLs in your VPC.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information only about ACLs
        /// that match criteria you specify. For example, you could get information
        /// for only the ACL associated with a particular subnet.
        /// The ACL must match at least one of the specified values for it to be
        /// included in the results.
        /// 
        /// You can specify multiple filters (e.g., the ACL is associated with
        /// a particular subnet and has an egress entry that denies traffic to
        /// a particular port). The result includes information for a particular
        /// ACL only if it matches all your filters. If there's no match, no
        /// special message is returned; the response is simply empty.
        /// 
        /// You can use wildcards with the filter values: * matches zero or more
        /// characters, and ? matches exactly one character.You can escape special
        /// characters using a backslash before the character. For example,
        /// a value of \*amazon\?\\ searches for the literal string *amazon?\.
        /// </remarks>
        /// <param name="request">Describe Network Acls  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Network Acls  Response from the service</returns>
        public DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request)
        {
            return Invoke<DescribeNetworkAclsResponse>(ConvertDescribeNetworkAcls(request));
        }

        /// <summary>
        /// Deletes a network ACL from a VPC.
        /// </summary>
        /// <remarks>
        /// The ACL must not have any subnets associated with it.
        /// You can't delete the default network ACL. For more
        /// information about network ACLs, go to Network ACLs in the
        /// Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Delete Network Acl  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Network Acl  Response from the service</returns>
        public DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request)
        {
            return Invoke<DeleteNetworkAclResponse>(ConvertDeleteNetworkAcl(request));
        }

        /// <summary>
        /// Changes which network ACL a subnet is associated with.
        /// </summary>
        /// <remarks>
        /// By default when you create a subnet, it's automatically associated with the
        /// default network ACL. For more information about network ACLs, go to
        /// Network ACLs in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Replace Network Acl Association  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Replace Network Acl Association  Response from the service</returns>
        public ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request)
        {
            return Invoke<ReplaceNetworkAclAssociationResponse>(ConvertReplaceNetworkAclAssociation(request));
        }

        /// <summary>
        /// Creates an entry (i.e., rule) in a network ACL with a rule number you specify.
        /// </summary>
        /// <remarks>
        /// Each network ACL has a set of numbered ingress rules and a separate set of numbered egress rules.
        /// When determining whether a packet should be allowed in or out of a subnet associated with the ACL,
        /// Amazon VPC processes the entries in the ACL according to the rule numbers, in ascending order.
        ///
        /// We recommend that you leave room between the rules (e.g., 100, 110, 120, etc.), and not number
        /// them sequentially (101, 102, 103, etc.). This allows you to easily add a new rule between existing
        /// ones without having to renumber the rules.
        ///
        /// After you add an entry, you can't modify it; you must either replace it, or create a new entry and delete
        /// the old one.
        /// </remarks>
        /// <param name="request">Create Network Acl Entry  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Network Acl Entry  Response from the service</returns>
        public CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request)
        {
            return Invoke<CreateNetworkAclEntryResponse>(ConvertCreateNetworkAclEntry(request));
        }

        /// <summary>
        /// Replaces an entry (i.e., rule) in a network ACL.
        /// </summary>
        /// <remarks>
        /// For more information about network ACLs, go to Network ACLs in the Amazon
        /// Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Replace Network Acl Entry  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Replace Network Acl Entry  Response from the service</returns>
        public ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request)
        {
            return Invoke<ReplaceNetworkAclEntryResponse>(ConvertReplaceNetworkAclEntry(request));
        }

        /// <summary>
        /// Deletes an ingress or egress entry (i.e., rule) from a network ACL.
        /// </summary>
        /// <remarks>
        /// For more information about network ACLs, go to Network ACLs
        /// in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Delete Network Acl Entry  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Network Acl Entry  Response from the service</returns>
        public DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request)
        {
            return Invoke<DeleteNetworkAclEntryResponse>(ConvertDeleteNetworkAclEntry(request));
        }

        /// <summary>
        /// Attaches a network interface to an instance.
        /// </summary>
        /// <param name="request">Attach Network Interface request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Attach Network Interface response from the service</returns>
        public AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request)
        {
            return Invoke<AttachNetworkInterfaceResponse>(ConvertAttachNetworkInterface(request));
        }

        /// <summary>
        /// Creates a network interface in the specified subnet.
        /// </summary>
        /// <remarks>
        /// This action is supported only in Amazon VPC.
        /// </remarks>
        /// <param name="request">Create Network Interface request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Network Interface response from the service</returns>
        public CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request)
        {
            return Invoke<CreateNetworkInterfaceResponse>(ConvertCreateNetworkInterface(request));
        }

        /// <summary>
        /// Deletes the specified network interface.
        /// </summary>
        /// <param name="request">Delete Network Interface request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Network Interface response from the service</returns>
        public DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request)
        {
            return Invoke<DeleteNetworkInterfaceResponse>(ConvertDeleteNetworkInterface(request));
        }

        /// <summary>
        /// Describes a Network Interface Attribute.
        /// Only one attribute can be specified per call.
        /// </summary>
        /// <remarks>Only one attribute can be specified per call.</remarks>
        /// <param name="request">Describe Network Interface Attribute request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Network Interface Attribute response from the service</returns>
        public DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request)
        {
            return Invoke<DescribeNetworkInterfaceAttributeResponse>(ConvertDescribeNetworkInterfaceAttribute(request));
        }

        /// <summary>
        /// Describes one or more Network Interfaces.
        /// </summary>
        /// <param name="request">Describe Network Interfaces request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Network Interfaces response from the service</returns>
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {                         
            return Invoke<DescribeNetworkInterfacesResponse>(ConvertDescribeNetworkInterfaces(request));
        }

        /// <summary>
        /// Detaches a network interface from an instance.
        /// </summary>
        /// <param name="request">Detach Network Interface request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Detach Network Interface response from the service</returns>
        public DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request)
        {
            return Invoke<DetachNetworkInterfaceResponse>(ConvertDetachNetworkInterface(request));
        }

        /// <summary>
        /// Modifies a network interface attribute. Only one attribute can be specified per call.
        /// </summary>
        /// <remarks>Only one attribute can be specified per call.</remarks>
        /// <param name="request">Modify Network Interface Attribute request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Network Interface Attribute response from the service</returns>
        public ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request)
        {
            return Invoke<ModifyNetworkInterfaceAttributeResponse>(ConvertModifyNetworkInterfaceAttribute(request));
        }

        /// <summary>
        /// Reset Network Interface Attribute request
        /// </summary>
        /// <remarks>Only one attribute can be specified per call.</remarks>
        /// <param name="request">Reset Network Interface Attribute request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reset Network Interface Attribute response from the service</returns>
        public ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request)
        {
            return Invoke<ResetNetworkInterfaceAttributeResponse>(ConvertResetNetworkInterfaceAttribute(request));
        }

        /// <summary>
        /// Returns the status of one or more volumes.
        /// </summary>
        /// <param name="request">Describe Volume Status request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Volume Status response from the service</returns>
        public DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request)
        {
            return Invoke<DescribeVolumeStatusResponse>(ConvertDescribeVolumeStatus(request));
        }

        /// <summary>
        /// Enables I/O operations for a volume that had I/O operations disabled
        /// because the data on the volume was potentially inconsistent.
        /// </summary>
        /// <param name="request">Enable Volume IO request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Enable Volume IO response from the service</returns>
        public EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request)
        {
            return Invoke<EnableVolumeIOResponse>(ConvertEnableVolumeIO(request));
        }

        /// <summary>
        /// Modifies a volume attribute.
        /// </summary>
        /// <param name="request">Modify Volume Attribute request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Volume Attribute response from the service</returns>
        public ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request)
        {
            return Invoke<ModifyVolumeAttributeResponse>(ConvertModifyVolumeAttribute(request));
        }

        /// <summary>
        /// Describes an attribute of a volume.
        /// </summary>
        /// <param name="request">Describe Volume Attribute request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Volume Attribute response from the service</returns>
        public DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request)
        {
            return Invoke<DescribeVolumeAttributeResponse>(ConvertDescribeVolumeAttribute(request));
        }

        /// <summary>
        /// Assigns one or more secondary private IP addresses to a network interface in Amazon VPC.
        /// </summary>
        /// <remarks>
        /// You can specify one or more specific secondary IP addresses that you want to assign,
        /// or you can specify a number of secondary IP addresses to be automatically assigned
        /// within the subnet’s CIDR block range.
        /// The number of secondary IP addresses that you can assign to an instance varies by instance type.
        /// </remarks>
        /// <param name="request">Assign Private Ip Addresses request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Assign Private Ip Addresses response from the service</returns>
        public AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request)
        {
            return Invoke<AssignPrivateIpAddressesResponse>(ConvertAssignPrivateIpAddresses(request));
        }

        /// <summary>
        /// Unassigns one or more secondary private IP addresses from a network
        /// interface in Amazon VPC.
        /// This command is only available in Amazon VPC
        /// </summary>
        /// <param name="request">Unassign Private Ip Addresses request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Unassign Private Ip Addresses response from the service</returns>
        public UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request)
        {
            return Invoke<UnassignPrivateIpAddressesResponse>(ConvertUnassignPrivateIpAddresses(request));
        }

        /// <summary>
        /// Creates a new static route associated with a VPN connection between an existing virtual private gateway
        /// and a VPN customer gateway. The static route allows traffic to be routed from the virtual private gateway
        /// to the VPN customer gateway.
        /// </summary>
        /// <remarks>
        /// We strongly recommend you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway.
        /// </remarks>
        /// <param name="request">Create Vpn Connection Route request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Vpn Connection Route response from the service</returns>
        public CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request)
        {
            return Invoke<CreateVpnConnectionRouteResponse>(ConvertCreateVpnConnectionRoute(request));
        }

        /// <summary>
        /// Deletes a static route associated with a VPN connection between an existing virtual private gateway and
        /// a VPN customer gateway. The static route allows traffic to be routed from the virtual private gateway to
        /// the VPN customer gateway.
        /// </summary>
        /// <remakrs>
        /// We strongly recommend you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway.
        /// </remakrs>
        /// <param name="request">Delete Vpn Connection Route request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Vpn Connection Route response from the service</returns>
        public DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request)
        {
            return Invoke<DeleteVpnConnectionRouteResponse>(ConvertDeleteVpnConnectionRoute(request));
        }

        /// <summary>
        /// Enables a virtual private gateway (VGW) to propagate routes to the
        /// routing tables of an Amazon VPC.
        /// </summary>
        /// <param name="request">Enable Virtual Gateway Route Propagation request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Enable Virtual Gateway Route Propagation response from the service</returns>
        public EnableVGWRoutePropagationResponse EnableVGWRoutePropagation(EnableVGWRoutePropagationRequest request)
        {
            return Invoke<EnableVGWRoutePropagationResponse>(ConvertEnableVGWRoutePropagation(request));
        }

        /// <summary>
        /// Disables a virtual private gateway (VGW) from propagating routes to
        /// the routing tables of an Amazon VPC.
        /// </summary>
        /// <param name="request">Disable Virtual Gateway Route Propagation request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Disable Virtual Gateway Route Propagation response from the service</returns>
        public DisableVGWRoutePropagationResponse DisableVGWRoutePropagation(DisableVGWRoutePropagationRequest request)
        {
            return Invoke<DisableVGWRoutePropagationResponse>(ConvertDisableVGWRoutePropagation(request));
        }

        /// <summary>
        /// Cancels the specified Reserved Instance listing in the Reserved Instance Marketplace.
        /// </summary>
        /// <param name="request">Cancel Reserved Instances Listing request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Cancel Reserved Instances Listing response from the service</returns>
        public CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request)
        {
            return Invoke<CancelReservedInstancesListingResponse>(ConvertCancelReservedInstancesListing(request));
        }

        /// <summary>
        /// Creates a new listing for Amazon EC2 Reserved Instances that will be sold in
        /// the Reserved Instance Marketplace. You can submit one Reserved Instance listing
        /// at a time.
        /// </summary>
        /// <remarks>
        /// The Reserved Instance Marketplace matches sellers who want to resell Reserved Instance
        /// capacity that they no longer need with buyers who want to purchase additional capacity.
        /// Reserved Instances bought and sold through the Reserved Instance Marketplace work
        /// like any other Reserved Instances.
        /// 
        /// If you want to sell your Reserved Instances, you must first register as a Seller in
        /// the Reserved Instance Marketplace. After completing the registration process, you can
        /// create a Reserved Instance Marketplace listing of some or all of your Reserved Instances,
        /// and specify the upfront price you want to receive for them.
        /// Your Reserved Instance listings then become available for purchase.
        /// </remarks>
        /// <param name="request">Create Reserved Instances Listing request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Reserved Instances Listing response from the service</returns>
        public CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request)
        {
            return Invoke<CreateReservedInstancesListingResponse>(ConvertCreateReservedInstancesListing(request));
        }

        /// <summary>
        /// Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.
        /// </summary>
        /// <param name="request">Describe Reserved Instances Listing request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Reserved Instances Listing response from the service</returns>
        public DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request)
        {
            return Invoke<DescribeReservedInstancesListingsResponse>(ConvertDescribeReservedInstancesListings(request));
        }

        /// <summary>
        /// Copies a snapshot from a source region to the current region.
        /// </summary>
        /// <param name="request">Copy Snapshot request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Copy Snapshot response from the service</returns>
        public CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            return Invoke<CopySnapshotResponse>(ConvertCopySnapshot(request));
        }

        /// <summary>
        /// Copies a image from a source region to the current region.
        /// </summary>
        /// <param name="request">Copy Image request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Copy Snapshot response from the service</returns>
        public CopyImageResponse CopyImage(CopyImageRequest request)
        {
            return Invoke<CopyImageResponse>(ConvertCopyImage(request));
        }

        /// <summary>
        /// Describes VPC attributes.
        /// </summary>
        /// <param name="request">Describe Vpc Attributes Request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Vpc Attributes response from the service</returns>
        public DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request)
        {
            return Invoke<DescribeVpcAttributeResponse>(ConvertDescribeVpcAttribute(request));
        }

        /// <summary>
        /// Modified attributes on a VPC.
        /// </summary>
        /// <param name="request">Modify Vpc Attributes Request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Vpc Attributes response from the service</returns>
        public ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request)
        {
            return Invoke<ModifyVpcAttributeResponse>(ConvertModifyVpcAttribute(request));
        }

        /// <summary>
        /// Describes account attributes of the caller
        /// </summary>
        /// <param name="request">Describe Account Attributes Request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Account Attributes response from the service</returns>
        public DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            return Invoke<DescribeAccountAttributesResponse>(ConvertDescribeAccountAttributes(request));
        }

        #endregion

        #region Private API

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonEC2Config instance
         */
        private static HttpWebRequest ConfigureWebRequest(int contentLength, AmazonEC2Config config)
        {
            string url;
            if (config.RegionEndpoint != null)
                url = "https://" + config.RegionEndpoint.GetEndpointForService(config.RegionEndpointServiceName).Hostname;
            else
                url = config.ServiceURL;

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            if (request != null)
            {
                request.ServicePoint.ConnectionLimit = config.ConnectionLimit;

                if (config.IsSetProxyHost() && config.IsSetProxyPort())
                {
                    WebProxy proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
                    request.Proxy = proxy;
                }
                if (request.Proxy != null && config.IsSetProxyCredentials())
                {
                    request.Proxy.Credentials = config.ProxyCredentials;
                }

                request.UserAgent = config.UserAgent;
                request.Method = "POST";
                request.Timeout = 50000;
                request.ContentType = AWSSDKUtils.UrlEncodedContent;
                request.ContentLength = contentLength;
            }

            return request;
        }

        /**
         * Invoke request and return response
         */
        private T Invoke<T>(IDictionary<string, string> parameters)
        {
            return Invoke<T>(parameters, null, null);
        }

        private T Invoke<T>(IDictionary<string, string> parameters, XmlElementEventHandler unknownElementHandler)
        {
            return Invoke<T>(parameters, unknownElementHandler, null);
        }

        private T Invoke<T>(IDictionary<string, string> parameters, ImmutableCredentials credentials)
        {
            return Invoke<T>(parameters, null, credentials);
        }

        /**
         * Invoke request and return response
         * Allows caller to pass in ImmutableCredentials. This way, if ImmutableCredentials were
         * needed before Invoke, the same credentials will be used in Invoke.
         * unknownElementHandler is passed for types that contain members tagged Obsolete, which would
         * be skipped by the serializer.
         */
        private T Invoke<T>(IDictionary<string, string> parameters, XmlElementEventHandler unknownElementHandler, ImmutableCredentials credentials)
        {
            string actionName = parameters["Action"];
            T response = default(T);
            HttpStatusCode statusCode = default(HttpStatusCode);

            /* Add required request parameters */
            AddRequiredParameters(parameters, credentials);

            string queryString = AWSSDKUtils.GetParametersAsString(parameters);

            byte[] requestData = Encoding.UTF8.GetBytes(queryString);
            bool shouldRetry = true;
            int retries = 0;
            int maxRetries = config.IsSetMaxErrorRetry() ? config.MaxErrorRetry : AWSSDKUtils.DefaultMaxRetry;

            do
            {
                string responseBody = null;
                HttpWebRequest request = ConfigureWebRequest(requestData.Length, config);
                /* Submit the request and read response body */
                try
                {
                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(requestData, 0, requestData.Length);
                    }
                    using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse)
                    {
                        if (httpResponse == null)
                        {
                            throw new WebException(
                                "The Web Response for a successful request is null!",
                                WebExceptionStatus.ProtocolError
                                );
                        }
                        statusCode = httpResponse.StatusCode;
                        using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd();
                        }
                    }

                    shouldRetry = ParseResponse<T>(actionName, unknownElementHandler, ref response, ref responseBody);
                }
                /* Web exception is thrown on unsucessful responses */
                catch (WebException we)
                {
                    shouldRetry = false;
                    using (HttpWebResponse httpErrorResponse = (HttpWebResponse)we.Response as HttpWebResponse)
                    {
                        if (httpErrorResponse == null)
                        {
                            // Abort the unsuccessful request
                            request.Abort();
                            throw we;
                        }
                        statusCode = httpErrorResponse.StatusCode;
                        using (StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd();
                        }

                        // Abort the unsuccessful request
                        request.Abort();
                    }

                    if (statusCode == HttpStatusCode.InternalServerError ||
                        statusCode == HttpStatusCode.ServiceUnavailable)
                    {
                        shouldRetry = true;
                        PauseOnRetry(++retries, maxRetries, statusCode, we, responseBody);
                    }
                    else
                    {
                        /* Attempt to deserialize response into ErrorResponse type */
                        try
                        {
                            using (XmlTextReader sr = new XmlTextReader(new StringReader(responseBody)))
                            {
                                XmlSerializer serializer = new XmlSerializer(typeof(ErrorResponse));
                                ErrorResponse errorResponse = (ErrorResponse)serializer.Deserialize(sr);
                                Error error = errorResponse.Error[0];

                                /* Throw formatted exception with information available from the error response */
                                throw new AmazonEC2Exception(
                                    error.Message,
                                    statusCode,
                                    error.Code,
                                    error.Type,
                                    errorResponse.RequestId,
                                    errorResponse.ToXML()
                                    );
                            }
                        }
                        /* Rethrow on deserializer error */
                        catch (Exception e)
                        {
                            if (e is AmazonEC2Exception)
                            {
                                throw;
                            }
                            else
                            {
                                throw ReportAnyErrors(responseBody, statusCode, we);
                            }
                        }
                    }
                }
                /* Catch other exceptions, attempt to convert to formatted exception,
                 * else rethrow wrapped exception */
                catch (Exception)
                {
                    // Abort the unsuccessful request
                    request.Abort();
                    throw;
                }
            } while (shouldRetry);

            return response;
        }

        private bool ParseResponse<T>(string actionName, XmlElementEventHandler unknownElementHandler, ref T response, ref string responseBody)
        {
            string transformedResponseBody = TransformResponse(actionName, responseBody);

            /* Attempt to deserialize response into <Action> Response type */
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            if (unknownElementHandler != null)
                serializer.UnknownElement += unknownElementHandler;
            using (XmlTextReader sr = new XmlTextReader(new StringReader(transformedResponseBody)))
            {
                response = (T)serializer.Deserialize(sr);
            }

            return false;
        }

        private string TransformResponse(string actionName, string responseBody)
        {
            string transformedResponse = responseBody;
            /* Perform response transformation */
            if (transformedResponse.Trim().EndsWith(String.Concat(actionName, "Response>")))
            {
                transformedResponse = Transform(transformedResponse, actionName, this.GetType());
            }
            return transformedResponse;
        }

        /**
         * Look for additional error strings in the response and return formatted exception
         */
        private static AmazonEC2Exception ReportAnyErrors(string responseBody, HttpStatusCode status, Exception innerException)
        {
            AmazonEC2Exception ex = null;

            if (responseBody != null && responseBody.StartsWith("<"))
            {
                Match errorMatcherOne = Regex.Match(
                    responseBody,
                    "<RequestId>(.*)</RequestId>.*<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?",
                    RegexOptions.Multiline
                    );
                Match errorMatcherTwo = Regex.Match(
                    responseBody,
                    "<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>",
                    RegexOptions.Multiline
                    );

                if (errorMatcherOne.Success)
                {
                    string requestId = errorMatcherOne.Groups[1].Value;
                    string code = errorMatcherOne.Groups[2].Value;
                    string message = errorMatcherOne.Groups[3].Value;

                    ex = new AmazonEC2Exception(message, status, code, "Unknown", requestId, responseBody);
                }
                else if (errorMatcherTwo.Success)
                {
                    string code = errorMatcherTwo.Groups[1].Value;
                    string message = errorMatcherTwo.Groups[2].Value;
                    string requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new AmazonEC2Exception(message, status, code, "Unknown", requestId, responseBody);
                }
                else
                {
                    ex = new AmazonEC2Exception("Internal Error", status, innerException);
                }
            }
            else
            {
                ex = new AmazonEC2Exception("Internal Error", status, innerException);
            }
            return ex;
        }

        /**
         * Exponential sleep on failed request
         */
        private static void PauseOnRetry(int retries, int maxRetries, HttpStatusCode status, Exception cause, string responseBody)
        {
            if (retries <= maxRetries)
            {
                int delay = (int)Math.Pow(4, retries) * 100;
                System.Threading.Thread.Sleep(delay);
            }
            else
            {
                throw ReportAnyErrors(responseBody, status, cause);
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<string, string> parameters, ImmutableCredentials immutableCredentials)
        {
            bool shouldDisposeCredentials = credentials == null;
            if (immutableCredentials == null)
                immutableCredentials = credentials.GetCredentials();
            try
            {
                if (immutableCredentials.UseToken)
                {
                    parameters["SecurityToken"] = immutableCredentials.Token;
                }
                parameters["AWSAccessKeyId"] = immutableCredentials.AccessKey;
                parameters["SignatureVersion"] = config.SignatureVersion;
                parameters["SignatureMethod"] = config.SignatureMethod;
                parameters["Timestamp"] = AWSSDKUtils.FormattedCurrentTimestampISO8601;
                parameters["Version"] = config.ServiceVersion;
                if (!config.SignatureVersion.Equals("2"))
                {
                    throw new AmazonEC2Exception("Invalid Signature Version specified");
                }

                string serviceURL;
                if (config.RegionEndpoint != null)
                    serviceURL = "https://" + config.RegionEndpoint.GetEndpointForService(config.RegionEndpointServiceName).Hostname;
                else
                    serviceURL = config.ServiceURL;

                string toSign = AWSSDKUtils.CalculateStringToSignV2(parameters, serviceURL);

                KeyedHashAlgorithm algorithm = KeyedHashAlgorithm.Create(config.SignatureMethod.ToUpper());
                string auth;

                if (immutableCredentials.UseSecureStringForSecretKey)
                {
                    auth = AWSSDKUtils.HMACSign(toSign, immutableCredentials.SecureSecretKey, algorithm);
                }
                else
                {
                    auth = AWSSDKUtils.HMACSign(toSign, immutableCredentials.ClearSecretKey, algorithm);
                }
                parameters["Signature"] = auth;
            }
            finally
            {
                if (shouldDisposeCredentials)
                    immutableCredentials.Dispose();
            }
        }

        /**
         * Convert ActivateLicenseRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertActivateLicense(ActivateLicenseRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ActivateLicense";
            if (request.IsSetLicenseId())
            {
                parameters["LicenseId"] = request.LicenseId;
            }
            if (request.IsSetCapacity())
            {
                parameters["Capacity"] = request.Capacity.ToString();
            }

            return parameters;
        }

        /**
         * Convert AllocateAddressRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAllocateAddress(AllocateAddressRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AllocateAddress";
            if (request.IsSetDomain())
            {
                parameters["Domain"] = request.Domain;
            }

            return parameters;
        }

        /**
         * Convert AttachVpnGatewayRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAttachVpnGateway(AttachVpnGatewayRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AttachVpnGateway";
            if (request.IsSetVpnGatewayId())
            {
                parameters["VpnGatewayId"] = request.VpnGatewayId;
            }
            if (request.IsSetVpcId())
            {
                parameters["VpcId"] = request.VpcId;
            }

            return parameters;
        }

        /**
         * Convert AssociateDhcpOptionsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAssociateDhcpOptions(AssociateDhcpOptionsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AssociateDhcpOptions";
            if (request.IsSetDhcpOptionsId())
            {
                parameters["DhcpOptionsId"] = request.DhcpOptionsId;
            }
            if (request.IsSetVpcId())
            {
                parameters["VpcId"] = request.VpcId;
            }

            return parameters;
        }

        /**
         * Convert AssociateAddressRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAssociateAddress(AssociateAddressRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AssociateAddress";
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }
            if (request.IsSetPublicIp())
            {
                parameters["PublicIp"] = request.PublicIp;
            }
            if (request.IsSetAllocationId())
            {
                parameters["AllocationId"] = request.AllocationId;
            }
            if (request.IsSetNetworkInterfaceId())
            {
                parameters["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (request.IsSetPrivateIpAddress())
            {
                parameters["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (request.IsSetAllowReassociation())
            {
                parameters["allowReassociation"] = request.AllowReassociation.ToString().ToLower();
            }

            return parameters;
        }

        /**
         * Convert AuthorizeSecurityGroupIngressRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AuthorizeSecurityGroupIngress";
            if (request.IsSetUserId())
            {
                parameters["UserId"] = request.UserId;
            }
            if (request.IsSetGroupId())
            {
                parameters["GroupId"] = request.GroupId;
            }
            if (request.IsSetGroupName())
            {
                parameters["GroupName"] = request.GroupName;
            }
            if (request.IsSetSourceSecurityGroupName())
            {
                parameters["SourceSecurityGroupName"] = request.SourceSecurityGroupName;
            }
            if (request.IsSetSourceSecurityGroupOwnerId())
            {
                parameters["SourceSecurityGroupOwnerId"] = request.SourceSecurityGroupOwnerId;
            }
            if (request.IsSetIpProtocol())
            {
                parameters["IpProtocol"] = request.IpProtocol;
            }
            if (request.IsSetFromPort())
            {
                parameters["FromPort"] = request.FromPort.ToString();
            }
            if (request.IsSetToPort())
            {
                parameters["ToPort"] = request.ToPort.ToString();
            }
            if (request.IsSetCidrIp())
            {
                parameters["CidrIp"] = request.CidrIp;
            }
            List<IpPermissionSpecification> authorizeSecurityGroupIngressRequestIpPermissionsList = request.IpPermissions;
            int authorizeSecurityGroupIngressRequestIpPermissionsListIndex = 1;
            foreach (IpPermissionSpecification authorizeSecurityGroupIngressRequestIpPermissions in authorizeSecurityGroupIngressRequestIpPermissionsList)
            {
                if (authorizeSecurityGroupIngressRequestIpPermissions.IsSetIpProtocol())
                {
                    parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "IpProtocol")] = authorizeSecurityGroupIngressRequestIpPermissions.IpProtocol;
                }
                if (authorizeSecurityGroupIngressRequestIpPermissions.IsSetFromPort())
                {
                    parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "FromPort")] = authorizeSecurityGroupIngressRequestIpPermissions.FromPort.ToString();
                }
                if (authorizeSecurityGroupIngressRequestIpPermissions.IsSetToPort())
                {
                    parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "ToPort")] = authorizeSecurityGroupIngressRequestIpPermissions.ToPort.ToString();
                }
                List<UserIdGroupPair> ipPermissionsGroupsList = authorizeSecurityGroupIngressRequestIpPermissions.Groups;
                int ipPermissionsGroupsListIndex = 1;
                foreach (UserIdGroupPair ipPermissionsGroups in ipPermissionsGroupsList)
                {
                    if (ipPermissionsGroups.IsSetUserId())
                    {
                        parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "Groups", ".", ipPermissionsGroupsListIndex, ".", "UserId")] = ipPermissionsGroups.UserId;
                    }
                    if (ipPermissionsGroups.IsSetGroupId())
                    {
                        parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "Groups", ".", ipPermissionsGroupsListIndex, ".", "GroupId")] = ipPermissionsGroups.GroupId;
                    }
                    if (ipPermissionsGroups.IsSetGroupName())
                    {
                        parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "Groups", ".", ipPermissionsGroupsListIndex, ".", "GroupName")] = ipPermissionsGroups.GroupName;
                    }

                    ipPermissionsGroupsListIndex++;
                }
                List<string> ipPermissionsIpRangesList = authorizeSecurityGroupIngressRequestIpPermissions.IpRanges;
                int ipPermissionsIpRangesListIndex = 1;
                foreach (string ipPermissionsIpRanges in ipPermissionsIpRangesList)
                {
                    parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "IpRanges", ".", ipPermissionsIpRangesListIndex, ".", "CidrIp")] = ipPermissionsIpRanges;
                    ipPermissionsIpRangesListIndex++;
                }

                authorizeSecurityGroupIngressRequestIpPermissionsListIndex++;
            }

            return parameters;
        }

        /**
         * Convert BundleInstanceRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertBundleInstance(BundleInstanceRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "BundleInstance";
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }
            if (request.IsSetStorage())
            {
                Storage bundleInstanceRequestStorage = request.Storage;
                if (bundleInstanceRequestStorage.IsSetS3())
                {
                    S3Storage storageS3 = bundleInstanceRequestStorage.S3;
                    if (storageS3.IsSetBucket())
                    {
                        parameters[String.Concat("Storage", ".", "S3", ".", "Bucket")] = storageS3.Bucket;
                    }
                    if (storageS3.IsSetPrefix())
                    {
                        parameters[String.Concat("Storage", ".", "S3", ".", "Prefix")] = storageS3.Prefix;
                    }
                    if (storageS3.IsSetAWSAccessKeyId())
                    {
                        parameters[String.Concat("Storage", ".", "S3", ".", "AWSAccessKeyId")] = storageS3.AWSAccessKeyId;
                    }
                    if (storageS3.IsSetUploadPolicy())
                    {
                        parameters[String.Concat("Storage", ".", "S3", ".", "UploadPolicy")] = storageS3.UploadPolicy;
                    }
                    if (storageS3.IsSetUploadPolicySignature())
                    {
                        parameters[String.Concat("Storage", ".", "S3", ".", "UploadPolicySignature")] = storageS3.UploadPolicySignature;
                    }
                }
            }

            return parameters;
        }

        /**
         * Convert CancelBundleTaskRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCancelBundleTask(CancelBundleTaskRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CancelBundleTask";
            if (request.IsSetBundleId())
            {
                parameters["BundleId"] = request.BundleId;
            }

            return parameters;
        }

        /**
         * Convert ConfirmProductInstanceRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertConfirmProductInstance(ConfirmProductInstanceRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ConfirmProductInstance";
            if (request.IsSetProductCode())
            {
                parameters["ProductCode"] = request.ProductCode;
            }
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }

            return parameters;
        }

        /**
         * Convert CreatePlacementGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreatePlacementGroup(CreatePlacementGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreatePlacementGroup";
            if (request.IsSetGroupName())
            {
                parameters["GroupName"] = request.GroupName;
            }
            if (request.IsSetStrategy())
            {
                parameters["Strategy"] = request.Strategy;
            }

            return parameters;
        }

        /**
         * Convert CreateImageRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateImage(CreateImageRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateImage";
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }
            if (request.IsSetName())
            {
                parameters["Name"] = request.Name;
            }
            if (request.IsSetDescription())
            {
                parameters["Description"] = request.Description;
            }
            if (request.IsSetNoReboot())
            {
                parameters["NoReboot"] = request.NoReboot.ToString().ToLower();
            }
            List<BlockDeviceMapping> createImageRequestBlockDeviceMappingList = request.BlockDeviceMapping;
            int registerImageRequestBlockDeviceMappingListIndex = 1;
            foreach (BlockDeviceMapping createImageRequestBlockDeviceMapping in createImageRequestBlockDeviceMappingList)
            {
                if (createImageRequestBlockDeviceMapping.IsSetDeviceName())
                {
                    parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "DeviceName")] = createImageRequestBlockDeviceMapping.DeviceName;
                }
                if (createImageRequestBlockDeviceMapping.IsSetVirtualName())
                {
                    parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "VirtualName")] = createImageRequestBlockDeviceMapping.VirtualName;
                }
                if (createImageRequestBlockDeviceMapping.IsSetEbs())
                {
                    EbsBlockDevice blockDeviceMappingEbs = createImageRequestBlockDeviceMapping.Ebs;
                    if (blockDeviceMappingEbs.IsSetSnapshotId())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "SnapshotId")] = blockDeviceMappingEbs.SnapshotId;
                    }
                    if (blockDeviceMappingEbs.IsSetVolumeSize())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "VolumeSize")] = blockDeviceMappingEbs.VolumeSize.ToString();
                    }
                    if (blockDeviceMappingEbs.IsSetDeleteOnTermination())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "DeleteOnTermination")] = blockDeviceMappingEbs.DeleteOnTermination.ToString().ToLower();
                    }
                    if (blockDeviceMappingEbs.IsSetVolumeType())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "VolumeType")] = blockDeviceMappingEbs.VolumeType;
                    }
                    if (blockDeviceMappingEbs.IsSetIOPS())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "Iops")] = blockDeviceMappingEbs.IOPS;
                    }
                }
                if (createImageRequestBlockDeviceMapping.IsSetNoDevice())
                {
                    parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "NoDevice")] = createImageRequestBlockDeviceMapping.NoDevice;
                }

                registerImageRequestBlockDeviceMappingListIndex++;
            } 
            return parameters;
        }

        /**
         * Convert CreateKeyPairRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateKeyPair(CreateKeyPairRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateKeyPair";
            if (request.IsSetKeyName())
            {
                parameters["KeyName"] = request.KeyName;
            }

            return parameters;
        }

        /**
         * Convert ImportKeyPairRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertImportKeyPair(ImportKeyPairRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ImportKeyPair";
            if (request.IsSetKeyName())
            {
                parameters["KeyName"] = request.KeyName;
            }
            if (request.IsSetPublicKeyMaterial())
            {
                parameters["PublicKeyMaterial"] = request.PublicKeyMaterial;
            }

            return parameters;
        }

        /**
         * Convert CreateTagsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateTags(CreateTagsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateTags";
            List<string> createTagsRequestResourceIdList = request.ResourceId;
            int createTagsRequestResourceIdListIndex = 1;
            foreach (string createTagsRequestResourceId in createTagsRequestResourceIdList)
            {
                parameters[String.Concat("ResourceId", ".", createTagsRequestResourceIdListIndex)] = createTagsRequestResourceId;
                createTagsRequestResourceIdListIndex++;
            }
            List<Tag> createTagsRequestTagList = request.Tag;
            int createTagsRequestTagListIndex = 1;
            foreach (Tag createTagsRequestTag in createTagsRequestTagList)
            {
                if (createTagsRequestTag.IsSetKey())
                {
                    parameters[String.Concat("Tag", ".", createTagsRequestTagListIndex, ".", "Key")] = createTagsRequestTag.Key;
                }
                if (createTagsRequestTag.IsSetValue())
                {
                    parameters[String.Concat("Tag", ".", createTagsRequestTagListIndex, ".", "Value")] = createTagsRequestTag.Value;
                }

                createTagsRequestTagListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeTagsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeTags(DescribeTagsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeTags";
            List<Filter> describeTagsRequestFilterList = request.Filter;
            int describeTagsRequestFilterListIndex = 1;
            foreach (Filter describeTagsRequestFilter in describeTagsRequestFilterList)
            {
                if (describeTagsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeTagsRequestFilterListIndex, ".", "Name")] = describeTagsRequestFilter.Name;
                }
                List<string> filterValueList = describeTagsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeTagsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeTagsRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DeleteTagsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteTags(DeleteTagsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteTags";
            List<string> deleteTagsRequestResourceIdList = request.ResourceId;
            int deleteTagsRequestResourceIdListIndex = 1;
            foreach (string deleteTagsRequestResourceId in deleteTagsRequestResourceIdList)
            {
                parameters[String.Concat("ResourceId", ".", deleteTagsRequestResourceIdListIndex)] = deleteTagsRequestResourceId;
                deleteTagsRequestResourceIdListIndex++;
            }
            List<DeleteTags> deleteTagsRequestTagList = request.Tag;
            int deleteTagsRequestTagListIndex = 1;
            foreach (DeleteTags deleteTagsRequestTag in deleteTagsRequestTagList)
            {
                if (deleteTagsRequestTag.IsSetKey())
                {
                    parameters[String.Concat("Tag", ".", deleteTagsRequestTagListIndex, ".", "Key")] = deleteTagsRequestTag.Key;
                }
                if (deleteTagsRequestTag.IsSetValue())
                {
                    parameters[String.Concat("Tag", ".", deleteTagsRequestTagListIndex, ".", "Value")] = deleteTagsRequestTag.Value;
                }

                deleteTagsRequestTagListIndex++;
            }

            return parameters;
        }

        /**
         * Convert CreateSubnetRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateSubnet(CreateSubnetRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateSubnet";
            if (request.IsSetVpcId())
            {
                parameters["VpcId"] = request.VpcId;
            }
            if (request.IsSetCidrBlock())
            {
                parameters["CidrBlock"] = request.CidrBlock;
            }
            if (request.IsSetAvailabilityZone())
            {
                parameters["AvailabilityZone"] = request.AvailabilityZone;
            }

            return parameters;
        }

        /**
         * Convert CreateVpnConnectionRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateVpnConnection(CreateVpnConnectionRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateVpnConnection";
            if (request.IsSetType())
            {
                parameters["Type"] = request.Type;
            }
            if (request.IsSetCustomerGatewayId())
            {
                parameters["CustomerGatewayId"] = request.CustomerGatewayId;
            }
            if (request.IsSetVpnGatewayId())
            {
                parameters["VpnGatewayId"] = request.VpnGatewayId;
            }
            if (request.IsSetStaticRoutesOnly())
            {
                parameters["Options.StaticRoutesOnly"] = request.StaticRoutesOnly.ToString();
            }
            return parameters;
        }

        /**
         * Convert CreateVpnGatewayRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateVpnGateway(CreateVpnGatewayRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateVpnGateway";
            if (request.IsSetType())
            {
                parameters["Type"] = request.Type;
            }
            if (request.IsSetAvailabilityZone())
            {
                parameters["AvailabilityZone"] = request.AvailabilityZone;
            }

            return parameters;
        }

        /**
         * Convert CreateDhcpOptionsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateDhcpOptions(CreateDhcpOptionsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateDhcpOptions";
            List<DhcpConfiguration> createDhcpOptionsRequestDhcpConfigurationList = request.DhcpConfiguration;
            int createDhcpOptionsRequestDhcpConfigurationListIndex = 1;
            foreach (DhcpConfiguration createDhcpOptionsRequestDhcpConfiguration in createDhcpOptionsRequestDhcpConfigurationList)
            {
                if (createDhcpOptionsRequestDhcpConfiguration.IsSetKey())
                {
                    parameters[String.Concat("DhcpConfiguration", ".", createDhcpOptionsRequestDhcpConfigurationListIndex, ".", "Key")] = createDhcpOptionsRequestDhcpConfiguration.Key;
                }
                List<string> dhcpConfigurationValueList = createDhcpOptionsRequestDhcpConfiguration.Value;
                int dhcpConfigurationValueListIndex = 1;
                foreach (string dhcpConfigurationValue in dhcpConfigurationValueList)
                {
                    parameters[String.Concat("DhcpConfiguration", ".", createDhcpOptionsRequestDhcpConfigurationListIndex, ".", "Value", ".", dhcpConfigurationValueListIndex)] = dhcpConfigurationValue;
                    dhcpConfigurationValueListIndex++;
                }

                createDhcpOptionsRequestDhcpConfigurationListIndex++;
            }

            return parameters;
        }

        /**
         * Convert CreateVpcRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateVpc(CreateVpcRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateVpc";
            if (request.IsSetCidrBlock())
            {
                parameters["CidrBlock"] = request.CidrBlock;
            }
            if (request.IsSetInstanceTenancy())
            {
                parameters["InstanceTenancy"] = request.InstanceTenancy;
            }

            return parameters;
        }

        /**
         * Convert CreateCustomerGatewayRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateCustomerGateway(CreateCustomerGatewayRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateCustomerGateway";
            if (request.IsSetType())
            {
                parameters["Type"] = request.Type;
            }
            if (request.IsSetIpAddress())
            {
                parameters["IpAddress"] = request.IpAddress;
            }
            if (request.IsSetBgpAsn())
            {
                parameters["BgpAsn"] = request.BgpAsn.ToString();
            }

            return parameters;
        }

        /**
         * Convert CreateSecurityGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateSecurityGroup";
            if (request.IsSetGroupName())
            {
                parameters["GroupName"] = request.GroupName;
            }
            if (request.IsSetGroupDescription())
            {
                parameters["GroupDescription"] = request.GroupDescription;
            }
            if (request.IsSetVpcId())
            {
                parameters["VpcId"] = request.VpcId;
            }

            return parameters;
        }

        /**
         * Convert DeactivateLicenseRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeactivateLicense(DeactivateLicenseRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeactivateLicense";
            if (request.IsSetLicenseId())
            {
                parameters["LicenseId"] = request.LicenseId;
            }
            if (request.IsSetCapacity())
            {
                parameters["Capacity"] = request.Capacity.ToString();
            }

            return parameters;
        }

        /**
         * Convert DeleteKeyPairRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteKeyPair(DeleteKeyPairRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteKeyPair";
            if (request.IsSetKeyName())
            {
                parameters["KeyName"] = request.KeyName;
            }

            return parameters;
        }

        /**
         * Convert DeletePlacementGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeletePlacementGroup(DeletePlacementGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeletePlacementGroup";
            if (request.IsSetGroupName())
            {
                parameters["GroupName"] = request.GroupName;
            }

            return parameters;
        }

        /**
         * Convert DeleteVpcRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteVpc(DeleteVpcRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteVpc";
            if (request.IsSetVpcId())
            {
                parameters["VpcId"] = request.VpcId;
            }

            return parameters;
        }

        /**
         * Convert DeleteVpnGatewayRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteVpnGateway(DeleteVpnGatewayRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteVpnGateway";
            if (request.IsSetVpnGatewayId())
            {
                parameters["VpnGatewayId"] = request.VpnGatewayId;
            }

            return parameters;
        }

        /**
         * Convert DeleteVpnConnectionRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteVpnConnection(DeleteVpnConnectionRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteVpnConnection";
            if (request.IsSetVpnConnectionId())
            {
                parameters["VpnConnectionId"] = request.VpnConnectionId;
            }

            return parameters;
        }

        /**
         * Convert DeleteDhcpOptionsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteDhcpOptions(DeleteDhcpOptionsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteDhcpOptions";
            if (request.IsSetDhcpOptionsId())
            {
                parameters["DhcpOptionsId"] = request.DhcpOptionsId;
            }

            return parameters;
        }

        /**
         * Convert DeleteCustomerGatewayRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteCustomerGateway(DeleteCustomerGatewayRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteCustomerGateway";
            if (request.IsSetCustomerGatewayId())
            {
                parameters["CustomerGatewayId"] = request.CustomerGatewayId;
            }

            return parameters;
        }

        /**
         * Convert DeleteSecurityGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteSecurityGroup";
            if (request.IsSetGroupId())
            {
                parameters["GroupId"] = request.GroupId;
            }
            if (request.IsSetGroupName())
            {
                parameters["GroupName"] = request.GroupName;
            }

            return parameters;
        }

        /**
         * Convert DeleteSubnetRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteSubnet(DeleteSubnetRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteSubnet";
            if (request.IsSetSubnetId())
            {
                parameters["SubnetId"] = request.SubnetId;
            }

            return parameters;
        }

        /**
         * Convert DescribeVpcsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeVpcs(DescribeVpcsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeVpcs";
            List<string> describeVpcsRequestVpcIdList = request.VpcId;
            int describeVpcsRequestVpcIdListIndex = 1;
            foreach (string describeVpcsRequestVpcId in describeVpcsRequestVpcIdList)
            {
                parameters[String.Concat("VpcId", ".", describeVpcsRequestVpcIdListIndex)] = describeVpcsRequestVpcId;
                describeVpcsRequestVpcIdListIndex++;
            }
            List<Filter> describeVpcsRequestFilterList = request.Filter;
            int describeVpcsRequestFilterListIndex = 1;
            foreach (Filter describeVpcsRequestFilter in describeVpcsRequestFilterList)
            {
                if (describeVpcsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeVpcsRequestFilterListIndex, ".", "Name")] = describeVpcsRequestFilter.Name;
                }
                List<string> filterValueList = describeVpcsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeVpcsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeVpcsRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeVpnGatewaysRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeVpnGateways(DescribeVpnGatewaysRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeVpnGateways";
            List<string> describeVpnGatewaysRequestVpnGatewayIdList = request.VpnGatewayId;
            int describeVpnGatewaysRequestVpnGatewayIdListIndex = 1;
            foreach (string describeVpnGatewaysRequestVpnGatewayId in describeVpnGatewaysRequestVpnGatewayIdList)
            {
                parameters[String.Concat("VpnGatewayId", ".", describeVpnGatewaysRequestVpnGatewayIdListIndex)] = describeVpnGatewaysRequestVpnGatewayId;
                describeVpnGatewaysRequestVpnGatewayIdListIndex++;
            }
            List<Filter> describeVpnGatewaysRequestFilterList = request.Filter;
            int describeVpnGatewaysRequestFilterListIndex = 1;
            foreach (Filter describeVpnGatewaysRequestFilter in describeVpnGatewaysRequestFilterList)
            {
                if (describeVpnGatewaysRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeVpnGatewaysRequestFilterListIndex, ".", "Name")] = describeVpnGatewaysRequestFilter.Name;
                }
                List<string> filterValueList = describeVpnGatewaysRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeVpnGatewaysRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeVpnGatewaysRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeDhcpOptionsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeDhcpOptions(DescribeDhcpOptionsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeDhcpOptions";
            List<string> describeDhcpOptionsRequestDhcpOptionsIdList = request.DhcpOptionsId;
            int describeDhcpOptionsRequestDhcpOptionsIdListIndex = 1;
            foreach (string describeDhcpOptionsRequestDhcpOptionsId in describeDhcpOptionsRequestDhcpOptionsIdList)
            {
                parameters[String.Concat("DhcpOptionsId", ".", describeDhcpOptionsRequestDhcpOptionsIdListIndex)] = describeDhcpOptionsRequestDhcpOptionsId;
                describeDhcpOptionsRequestDhcpOptionsIdListIndex++;
            }
            List<Filter> describeDhcpOptionsRequestFilterList = request.Filter;
            int describeDhcpOptionsRequestFilterListIndex = 1;
            foreach (Filter describeDhcpOptionsRequestFilter in describeDhcpOptionsRequestFilterList)
            {
                if (describeDhcpOptionsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeDhcpOptionsRequestFilterListIndex, ".", "Name")] = describeDhcpOptionsRequestFilter.Name;
                }
                List<string> filterValueList = describeDhcpOptionsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeDhcpOptionsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeDhcpOptionsRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeVpnConnectionsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeVpnConnections(DescribeVpnConnectionsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeVpnConnections";
            List<string> describeVpnConnectionsRequestVpnConnectionIdList = request.VpnConnectionId;
            int describeVpnConnectionsRequestVpnConnectionIdListIndex = 1;
            foreach (string describeVpnConnectionsRequestVpnConnectionId in describeVpnConnectionsRequestVpnConnectionIdList)
            {
                parameters[String.Concat("VpnConnectionId", ".", describeVpnConnectionsRequestVpnConnectionIdListIndex)] = describeVpnConnectionsRequestVpnConnectionId;
                describeVpnConnectionsRequestVpnConnectionIdListIndex++;
            }
            List<Filter> describeVpnConnectionsRequestFilterList = request.Filter;
            int describeVpnConnectionsRequestFilterListIndex = 1;
            foreach (Filter describeVpnConnectionsRequestFilter in describeVpnConnectionsRequestFilterList)
            {
                if (describeVpnConnectionsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeVpnConnectionsRequestFilterListIndex, ".", "Name")] = describeVpnConnectionsRequestFilter.Name;
                }
                List<string> filterValueList = describeVpnConnectionsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeVpnConnectionsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeVpnConnectionsRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeCustomerGatewaysRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeCustomerGateways";
            List<string> describeCustomerGatewaysRequestCustomerGatewayIdList = request.CustomerGatewayId;
            int describeCustomerGatewaysRequestCustomerGatewayIdListIndex = 1;
            foreach (string describeCustomerGatewaysRequestCustomerGatewayId in describeCustomerGatewaysRequestCustomerGatewayIdList)
            {
                parameters[String.Concat("CustomerGatewayId", ".", describeCustomerGatewaysRequestCustomerGatewayIdListIndex)] = describeCustomerGatewaysRequestCustomerGatewayId;
                describeCustomerGatewaysRequestCustomerGatewayIdListIndex++;
            }
            List<Filter> describeCustomerGatewaysRequestFilterList = request.Filter;
            int describeCustomerGatewaysRequestFilterListIndex = 1;
            foreach (Filter describeCustomerGatewaysRequestFilter in describeCustomerGatewaysRequestFilterList)
            {
                if (describeCustomerGatewaysRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeCustomerGatewaysRequestFilterListIndex, ".", "Name")] = describeCustomerGatewaysRequestFilter.Name;
                }
                List<string> filterValueList = describeCustomerGatewaysRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeCustomerGatewaysRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeCustomerGatewaysRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeReservedInstancesOfferingsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeReservedInstancesOfferings";
            List<string> describeReservedInstancesOfferingsRequestReservedInstancesIdList = request.ReservedInstancesId;
            int describeReservedInstancesOfferingsRequestReservedInstancesIdListIndex = 1;
            foreach (string describeReservedInstancesOfferingsRequestReservedInstancesId in describeReservedInstancesOfferingsRequestReservedInstancesIdList)
            {
                parameters[String.Concat("ReservedInstancesOfferingId", ".", describeReservedInstancesOfferingsRequestReservedInstancesIdListIndex)] = describeReservedInstancesOfferingsRequestReservedInstancesId;
                describeReservedInstancesOfferingsRequestReservedInstancesIdListIndex++;
            }
            if (request.IsSetInstanceType())
            {
                parameters["InstanceType"] = request.InstanceType;
            }
            if (request.IsSetAvailabilityZone())
            {
                parameters["AvailabilityZone"] = request.AvailabilityZone;
            }
            if (request.IsSetProductDescription())
            {
                parameters["ProductDescription"] = request.ProductDescription;
            }
            List<Filter> describeReservedInstancesOfferingsRequestFilterList = request.Filter;
            int describeReservedInstancesOfferingsRequestFilterListIndex = 1;
            foreach (Filter describeReservedInstancesOfferingsRequestFilter in describeReservedInstancesOfferingsRequestFilterList)
            {
                if (describeReservedInstancesOfferingsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeReservedInstancesOfferingsRequestFilterListIndex, ".", "Name")] = describeReservedInstancesOfferingsRequestFilter.Name;
                }
                List<string> filterValueList = describeReservedInstancesOfferingsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeReservedInstancesOfferingsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeReservedInstancesOfferingsRequestFilterListIndex++;
            }
            if (request.IsSetInstanceTenancy())
            {
                parameters["InstanceTenancy"] = request.InstanceTenancy;
            }
            if (request.IsSetOfferingType())
            {
                parameters["OfferingType"] = request.OfferingType;
            }
            if (request.IsSetIncludeMarketplace())
            {
                parameters["IncludeMarketplace"] = request.IncludeMarketplace.ToString();
            }
            if (request.IsSetMinDuration())
            {
                parameters["MinDuration"] = request.MinDuration.ToString();
            }
            if (request.IsSetMaxDuration())
            {
                parameters["MaxDuration"] = request.MaxDuration.ToString();
            }
            if (request.IsSetMaxInstanceCount())
            {
                parameters["MaxInstanceCount"] = request.MaxInstanceCount.ToString();
            }
            if (request.IsSetMaxResults())
            {
                parameters["MaxResults"] = request.MaxResults.ToString();
            }
            if (request.IsSetNextToken())
            {
                parameters["NextToken"] = request.NextToken;
            }
            return parameters;
        }

        /**
         * Convert DescribeReservedInstancesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeReservedInstances";
            List<string> describeReservedInstancesRequestReservedInstancesIdList = request.ReservedInstancesId;
            int describeReservedInstancesRequestReservedInstancesIdListIndex = 1;
            foreach (string describeReservedInstancesRequestReservedInstancesId in describeReservedInstancesRequestReservedInstancesIdList)
            {
                parameters[String.Concat("ReservedInstancesId", ".", describeReservedInstancesRequestReservedInstancesIdListIndex)] = describeReservedInstancesRequestReservedInstancesId;
                describeReservedInstancesRequestReservedInstancesIdListIndex++;
            }
            List<Filter> describeReservedInstancesRequestFilterList = request.Filter;
            int describeReservedInstancesRequestFilterListIndex = 1;
            foreach (Filter describeReservedInstancesRequestFilter in describeReservedInstancesRequestFilterList)
            {
                if (describeReservedInstancesRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeReservedInstancesRequestFilterListIndex, ".", "Name")] = describeReservedInstancesRequestFilter.Name;
                }
                List<string> filterValueList = describeReservedInstancesRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeReservedInstancesRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeReservedInstancesRequestFilterListIndex++;
            }
            if (request.IsSetOfferingType())
            {
                parameters["OfferingType"] = request.OfferingType;
            }

            return parameters;
        }

        /**
         * Convert DescribeSubnetsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeSubnets(DescribeSubnetsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeSubnets";
            List<string> describeSubnetsRequestSubnetIdList = request.SubnetId;
            int describeSubnetsRequestSubnetIdListIndex = 1;
            foreach (string describeSubnetsRequestSubnetId in describeSubnetsRequestSubnetIdList)
            {
                parameters[String.Concat("SubnetId", ".", describeSubnetsRequestSubnetIdListIndex)] = describeSubnetsRequestSubnetId;
                describeSubnetsRequestSubnetIdListIndex++;
            }
            List<Filter> describeSubnetsRequestFilterList = request.Filter;
            int describeSubnetsRequestFilterListIndex = 1;
            foreach (Filter describeSubnetsRequestFilter in describeSubnetsRequestFilterList)
            {
                if (describeSubnetsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeSubnetsRequestFilterListIndex, ".", "Name")] = describeSubnetsRequestFilter.Name;
                }
                List<string> filterValueList = describeSubnetsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeSubnetsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeSubnetsRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert PurchaseReservedInstancesOfferingRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertPurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "PurchaseReservedInstancesOffering";
            if (request.IsSetReservedInstancesOfferingId())
            {
                parameters["ReservedInstancesOfferingId"] = request.ReservedInstancesOfferingId;
            }
            if (request.IsSetInstanceCount())
            {
                parameters["InstanceCount"] = request.InstanceCount;
            }
            if (request.IsSetLimitPrice())
            {
                ReservedInstanceLimitPrice limitPrice = request.LimitPrice;
                if (limitPrice.IsSetAmount())
                    parameters["LimitPrice.Amount"] = request.LimitPrice.Amount.ToString();
                if (limitPrice.IsSetCurrencyCode())
                    parameters["LimitPrice.CurrencyCode"] = request.LimitPrice.CurrencyCode;
            }

            return parameters;
        }

        /**
         * Convert DeregisterImageRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeregisterImage(DeregisterImageRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeregisterImage";
            if (request.IsSetImageId())
            {
                parameters["ImageId"] = request.ImageId;
            }

            return parameters;
        }

        /**
         * Convert DescribeAddressesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeAddresses(DescribeAddressesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeAddresses";
            List<string> describeAddressesRequestPublicIpList = request.PublicIp;
            int describeAddressesRequestPublicIpListIndex = 1;
            foreach (string describeAddressesRequestPublicIp in describeAddressesRequestPublicIpList)
            {
                parameters[String.Concat("PublicIp", ".", describeAddressesRequestPublicIpListIndex)] = describeAddressesRequestPublicIp;
                describeAddressesRequestPublicIpListIndex++;
            }
            List<string> describeAddressesRequestAllocationIdList = request.AllocationId;
            int describeAddressesRequestAllocationIdListIndex = 1;
            foreach (string describeAddressesRequestAllocationId in describeAddressesRequestAllocationIdList)
            {
                parameters[String.Concat("AllocationId", ".", describeAddressesRequestAllocationIdListIndex)] = describeAddressesRequestAllocationId;
                describeAddressesRequestAllocationIdListIndex++;
            }
            List<Filter> describeAddressesRequestFilterList = request.Filter;
            int describeAddressesRequestFilterListIndex = 1;
            foreach (Filter describeAddressesRequestFilter in describeAddressesRequestFilterList)
            {
                if (describeAddressesRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeAddressesRequestFilterListIndex, ".", "Name")] = describeAddressesRequestFilter.Name;
                }
                List<string> filterValueList = describeAddressesRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeAddressesRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeAddressesRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeAvailabilityZonesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeAvailabilityZones";
            List<string> describeAvailabilityZonesRequestZoneNameList = request.ZoneName;
            int describeAvailabilityZonesRequestZoneNameListIndex = 1;
            foreach (string describeAvailabilityZonesRequestZoneName in describeAvailabilityZonesRequestZoneNameList)
            {
                parameters[String.Concat("ZoneName", ".", describeAvailabilityZonesRequestZoneNameListIndex)] = describeAvailabilityZonesRequestZoneName;
                describeAvailabilityZonesRequestZoneNameListIndex++;
            }
            List<Filter> describeAvailabilityZonesRequestFilterList = request.Filter;
            int describeAvailabilityZonesRequestFilterListIndex = 1;
            foreach (Filter describeAvailabilityZonesRequestFilter in describeAvailabilityZonesRequestFilterList)
            {
                if (describeAvailabilityZonesRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeAvailabilityZonesRequestFilterListIndex, ".", "Name")] = describeAvailabilityZonesRequestFilter.Name;
                }
                List<string> filterValueList = describeAvailabilityZonesRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeAvailabilityZonesRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeAvailabilityZonesRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeBundleTasksRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeBundleTasks(DescribeBundleTasksRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeBundleTasks";
            List<string> describeBundleTasksRequestBundleIdList = request.BundleId;
            int describeBundleTasksRequestBundleIdListIndex = 1;
            foreach (string describeBundleTasksRequestBundleId in describeBundleTasksRequestBundleIdList)
            {
                parameters[String.Concat("BundleId", ".", describeBundleTasksRequestBundleIdListIndex)] = describeBundleTasksRequestBundleId;
                describeBundleTasksRequestBundleIdListIndex++;
            }
            List<Filter> describeBundleTasksRequestFilterList = request.Filter;
            int describeBundleTasksRequestFilterListIndex = 1;
            foreach (Filter describeBundleTasksRequestFilter in describeBundleTasksRequestFilterList)
            {
                if (describeBundleTasksRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeBundleTasksRequestFilterListIndex, ".", "Name")] = describeBundleTasksRequestFilter.Name;
                }
                List<string> filterValueList = describeBundleTasksRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeBundleTasksRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeBundleTasksRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeImageAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeImageAttribute(DescribeImageAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeImageAttribute";
            if (request.IsSetImageId())
            {
                parameters["ImageId"] = request.ImageId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }

            return parameters;
        }

        /**
         * Convert DescribeInstanceAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeInstanceAttribute";
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }

            return parameters;
        }

        /**
         * Convert DescribeSnapshotAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeSnapshotAttribute";
            if (request.IsSetSnapshotId())
            {
                parameters["SnapshotId"] = request.SnapshotId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }

            return parameters;
        }

        /**
         * Convert DescribeImagesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeImages(DescribeImagesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeImages";
            List<string> describeImagesRequestImageIdList = request.ImageId;
            int describeImagesRequestImageIdListIndex = 1;
            foreach (string describeImagesRequestImageId in describeImagesRequestImageIdList)
            {
                parameters[String.Concat("ImageId", ".", describeImagesRequestImageIdListIndex)] = describeImagesRequestImageId;
                describeImagesRequestImageIdListIndex++;
            }
            List<string> describeImagesRequestOwnerList = request.Owner;
            int describeImagesRequestOwnerListIndex = 1;
            foreach (string describeImagesRequestOwner in describeImagesRequestOwnerList)
            {
                parameters[String.Concat("Owner", ".", describeImagesRequestOwnerListIndex)] = describeImagesRequestOwner;
                describeImagesRequestOwnerListIndex++;
            }
            List<string> describeImagesRequestExecutableByList = request.ExecutableBy;
            int describeImagesRequestExecutableByListIndex = 1;
            foreach (string describeImagesRequestExecutableBy in describeImagesRequestExecutableByList)
            {
                parameters[String.Concat("ExecutableBy", ".", describeImagesRequestExecutableByListIndex)] = describeImagesRequestExecutableBy;
                describeImagesRequestExecutableByListIndex++;
            }
            List<Filter> describeImagesRequestFilterList = request.Filter;
            int describeImagesRequestFilterListIndex = 1;
            foreach (Filter describeImagesRequestFilter in describeImagesRequestFilterList)
            {
                if (describeImagesRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeImagesRequestFilterListIndex, ".", "Name")] = describeImagesRequestFilter.Name;
                }
                List<string> filterValueList = describeImagesRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeImagesRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeImagesRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeInstanceStatusRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeInstanceStatus(DescribeInstanceStatusRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeInstanceStatus";
            List<string> describeInstanceStatusRequestInstanceIdList = request.InstanceId;
            int describeInstanceStatusRequestInstanceIdListIndex = 1;
            foreach (string describeInstanceStatusRequestInstanceId in describeInstanceStatusRequestInstanceIdList)
            {
                parameters[String.Concat("InstanceId", ".", describeInstanceStatusRequestInstanceIdListIndex)] = describeInstanceStatusRequestInstanceId;
                describeInstanceStatusRequestInstanceIdListIndex++;
            }
            List<Filter> describeInstanceStatusRequestFilterList = request.Filter;
            int describeInstanceStatusRequestFilterListIndex = 1;
            foreach (Filter describeInstanceStatusRequestFilter in describeInstanceStatusRequestFilterList)
            {
                if (describeInstanceStatusRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeInstanceStatusRequestFilterListIndex, ".", "Name")] = describeInstanceStatusRequestFilter.Name;
                }
                List<string> filterValueList = describeInstanceStatusRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeInstanceStatusRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeInstanceStatusRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert ReportInstanceStatusRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertReportInstanceStatus(ReportInstanceStatusRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ReportInstanceStatus";

            List<string> reportInstanceStatusRequestInstanceIdList = request.InstanceId;
            int reportInstanceStatusRequestInstanceIdListIndex = 1;
            foreach (string reportInstanceStatusRequestInstanceId in reportInstanceStatusRequestInstanceIdList)
            {
                parameters[String.Concat("InstanceId", ".", reportInstanceStatusRequestInstanceIdListIndex)] = reportInstanceStatusRequestInstanceId;
                reportInstanceStatusRequestInstanceIdListIndex++;
            }

            if (request.IsSetStatus())
                parameters["Status"] = request.Status;
            if (request.IsSetStartTime())
                parameters["StartTime"] = request.StartTime;
            if (request.IsSetEndTime())
                parameters["EndTime"] = request.EndTime;

            List<string> reportInstanceStatusReasonCodeList = request.ReasonCode;
            int reportInstanceStatusReasonCodeListIndex = 1;
            foreach (string reportInstanceStatusReasonCode in reportInstanceStatusReasonCodeList)
            {
                parameters[String.Concat("ReasonCode", ".", reportInstanceStatusReasonCodeListIndex)] = reportInstanceStatusReasonCode;
                reportInstanceStatusReasonCodeListIndex++;
            }

            if (request.IsSetDescription())
                parameters["Description"] = request.Description;

            return parameters;
        }

        /**
         * Convert DescribeInstancesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeInstances(DescribeInstancesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeInstances";
            List<string> describeInstancesRequestInstanceIdList = request.InstanceId;
            int describeInstancesRequestInstanceIdListIndex = 1;
            foreach (string describeInstancesRequestInstanceId in describeInstancesRequestInstanceIdList)
            {
                parameters[String.Concat("InstanceId", ".", describeInstancesRequestInstanceIdListIndex)] = describeInstancesRequestInstanceId;
                describeInstancesRequestInstanceIdListIndex++;
            }
            List<Filter> describeInstancesRequestFilterList = request.Filter;
            int describeInstancesRequestFilterListIndex = 1;
            foreach (Filter describeInstancesRequestFilter in describeInstancesRequestFilterList)
            {
                if (describeInstancesRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeInstancesRequestFilterListIndex, ".", "Name")] = describeInstancesRequestFilter.Name;
                }
                List<string> filterValueList = describeInstancesRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeInstancesRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeInstancesRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeKeyPairsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeKeyPairs";
            List<string> describeKeyPairsRequestKeyNameList = request.KeyName;
            int describeKeyPairsRequestKeyNameListIndex = 1;
            foreach (string describeKeyPairsRequestKeyName in describeKeyPairsRequestKeyNameList)
            {
                parameters[String.Concat("KeyName", ".", describeKeyPairsRequestKeyNameListIndex)] = describeKeyPairsRequestKeyName;
                describeKeyPairsRequestKeyNameListIndex++;
            }
            List<Filter> describeKeyPairsRequestFilterList = request.Filter;
            int describeKeyPairsRequestFilterListIndex = 1;
            foreach (Filter describeKeyPairsRequestFilter in describeKeyPairsRequestFilterList)
            {
                if (describeKeyPairsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeKeyPairsRequestFilterListIndex, ".", "Name")] = describeKeyPairsRequestFilter.Name;
                }
                List<string> filterValueList = describeKeyPairsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeKeyPairsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeKeyPairsRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeLicensesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeLicenses(DescribeLicensesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeLicenses";
            List<string> describeLicensesRequestLicenseIdList = request.LicenseId;
            int describeLicensesRequestLicenseIdListIndex = 1;
            foreach (string describeLicensesRequestLicenseId in describeLicensesRequestLicenseIdList)
            {
                parameters[String.Concat("LicenseId", ".", describeLicensesRequestLicenseIdListIndex)] = describeLicensesRequestLicenseId;
                describeLicensesRequestLicenseIdListIndex++;
            }
            List<Filter> describeLicensesRequestFilterList = request.Filter;
            int describeLicensesRequestFilterListIndex = 1;
            foreach (Filter describeLicensesRequestFilter in describeLicensesRequestFilterList)
            {
                if (describeLicensesRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeLicensesRequestFilterListIndex, ".", "Name")] = describeLicensesRequestFilter.Name;
                }
                List<string> filterValueList = describeLicensesRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeLicensesRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeLicensesRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribePlacementGroupsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribePlacementGroups(DescribePlacementGroupsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribePlacementGroups";
            List<string> describePlacementGroupsRequestGroupNameList = request.GroupName;
            int describePlacementGroupsRequestGroupNameListIndex = 1;
            foreach (string describePlacementGroupsRequestGroupName in describePlacementGroupsRequestGroupNameList)
            {
                parameters[String.Concat("GroupName", ".", describePlacementGroupsRequestGroupNameListIndex)] = describePlacementGroupsRequestGroupName;
                describePlacementGroupsRequestGroupNameListIndex++;
            }
            List<Filter> describePlacementGroupsRequestFilterList = request.Filter;
            int describePlacementGroupsRequestFilterListIndex = 1;
            foreach (Filter describePlacementGroupsRequestFilter in describePlacementGroupsRequestFilterList)
            {
                if (describePlacementGroupsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describePlacementGroupsRequestFilterListIndex, ".", "Name")] = describePlacementGroupsRequestFilter.Name;
                }
                List<string> filterValueList = describePlacementGroupsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describePlacementGroupsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describePlacementGroupsRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeSecurityGroupsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeSecurityGroups";
            List<string> describeSecurityGroupsRequestGroupNameList = request.GroupName;
            int describeSecurityGroupsRequestGroupNameListIndex = 1;
            foreach (string describeSecurityGroupsRequestGroupName in describeSecurityGroupsRequestGroupNameList)
            {
                parameters[String.Concat("GroupName", ".", describeSecurityGroupsRequestGroupNameListIndex)] = describeSecurityGroupsRequestGroupName;
                describeSecurityGroupsRequestGroupNameListIndex++;
            }
            List<string> describeSecurityGroupsRequestGroupIdList = request.GroupId;
            int describeSecurityGroupsRequestGroupIdListIndex = 1;
            foreach (string describeSecurityGroupsRequestGroupId in describeSecurityGroupsRequestGroupIdList)
            {
                parameters[String.Concat("GroupId", ".", describeSecurityGroupsRequestGroupIdListIndex)] = describeSecurityGroupsRequestGroupId;
                describeSecurityGroupsRequestGroupIdListIndex++;
            }
            List<Filter> describeSecurityGroupsRequestFilterList = request.Filter;
            int describeSecurityGroupsRequestFilterListIndex = 1;
            foreach (Filter describeSecurityGroupsRequestFilter in describeSecurityGroupsRequestFilterList)
            {
                if (describeSecurityGroupsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeSecurityGroupsRequestFilterListIndex, ".", "Name")] = describeSecurityGroupsRequestFilter.Name;
                }
                List<string> filterValueList = describeSecurityGroupsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeSecurityGroupsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeSecurityGroupsRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DisassociateAddressRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDisassociateAddress(DisassociateAddressRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DisassociateAddress";
            if (request.IsSetPublicIp())
            {
                parameters["PublicIp"] = request.PublicIp;
            }
            if (request.IsSetAssociationId())
            {
                parameters["AssociationId"] = request.AssociationId;
            }

            return parameters;
        }

        /**
         * Convert GetConsoleOutputRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertGetConsoleOutput(GetConsoleOutputRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "GetConsoleOutput";
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }

            return parameters;
        }

        /**
         * Convert GetPasswordDataRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertGetPasswordData(GetPasswordDataRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "GetPasswordData";
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }

            return parameters;
        }

        /**
         * Convert ModifyImageAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ModifyImageAttribute";
            if (request.IsSetImageId())
            {
                parameters["ImageId"] = request.ImageId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }
            if (request.IsSetOperationType())
            {
                parameters["OperationType"] = request.OperationType;
            }
            List<string> modifyImageAttributeRequestUserIdList = request.UserId;
            int modifyImageAttributeRequestUserIdListIndex = 1;
            foreach (string modifyImageAttributeRequestUserId in modifyImageAttributeRequestUserIdList)
            {
                parameters[String.Concat("UserId", ".", modifyImageAttributeRequestUserIdListIndex)] = modifyImageAttributeRequestUserId;
                modifyImageAttributeRequestUserIdListIndex++;
            }
            List<string> modifyImageAttributeRequestUserGroupList = request.UserGroup;
            int modifyImageAttributeRequestUserGroupListIndex = 1;
            foreach (string modifyImageAttributeRequestUserGroup in modifyImageAttributeRequestUserGroupList)
            {
                parameters[String.Concat("UserGroup", ".", modifyImageAttributeRequestUserGroupListIndex)] = modifyImageAttributeRequestUserGroup;
                modifyImageAttributeRequestUserGroupListIndex++;
            }
            List<string> modifyImageAttributeRequestProductCodeList = request.ProductCode;
            int modifyImageAttributeRequestProductCodeListIndex = 1;
            foreach (string modifyImageAttributeRequestProductCode in modifyImageAttributeRequestProductCodeList)
            {
                parameters[String.Concat("ProductCode", ".", modifyImageAttributeRequestProductCodeListIndex)] = modifyImageAttributeRequestProductCode;
                modifyImageAttributeRequestProductCodeListIndex++;
            }
            if (request.IsSetDescription())
            {
                parameters.Remove("Attribute");
                parameters["Description.Value"] = request.Description;
            }

            return parameters;
        }

        /**
         * Convert ModifyInstanceAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ModifyInstanceAttribute";
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }
            if (request.IsSetValue())
            {
                parameters["Value"] = request.Value;
            }
            List<InstanceBlockDeviceMappingParameter> modifyInstanceAttributeRequestBlockDeviceMappingList = request.BlockDeviceMapping;
            int modifyInstanceAttributeRequestBlockDeviceMappingListIndex = 1;
            foreach (InstanceBlockDeviceMappingParameter modifyInstanceAttributeRequestBlockDeviceMapping in modifyInstanceAttributeRequestBlockDeviceMappingList)
            {
                if (modifyInstanceAttributeRequestBlockDeviceMapping.IsSetDeviceName())
                {
                    parameters[String.Concat("BlockDeviceMapping", ".", modifyInstanceAttributeRequestBlockDeviceMappingListIndex, ".", "DeviceName")] = modifyInstanceAttributeRequestBlockDeviceMapping.DeviceName;
                }
                if (modifyInstanceAttributeRequestBlockDeviceMapping.IsSetVirtualName())
                {
                    parameters[String.Concat("BlockDeviceMapping", ".", modifyInstanceAttributeRequestBlockDeviceMappingListIndex, ".", "VirtualName")] = modifyInstanceAttributeRequestBlockDeviceMapping.VirtualName;
                }
                if (modifyInstanceAttributeRequestBlockDeviceMapping.IsSetEbs())
                {
                    InstanceEbsBlockDeviceParameter blockDeviceMappingEbs = modifyInstanceAttributeRequestBlockDeviceMapping.Ebs;
                    if (blockDeviceMappingEbs.IsSetVolumeId())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", modifyInstanceAttributeRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "VolumeId")] = blockDeviceMappingEbs.VolumeId;
                    }
                    if (blockDeviceMappingEbs.IsSetDeleteOnTermination())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", modifyInstanceAttributeRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "DeleteOnTermination")] = blockDeviceMappingEbs.DeleteOnTermination.ToString().ToLower();
                    }
                }
                if (modifyInstanceAttributeRequestBlockDeviceMapping.IsSetNoDevice())
                {
                    parameters[String.Concat("BlockDeviceMapping", ".", modifyInstanceAttributeRequestBlockDeviceMappingListIndex, ".", "NoDevice")] = modifyInstanceAttributeRequestBlockDeviceMapping.NoDevice;
                }

                modifyInstanceAttributeRequestBlockDeviceMappingListIndex++;
            }
            List<string> modifyInstanceAttributeRequestGroupIdList = request.GroupId;
            int modifyInstanceAttributeRequestGroupIdListIndex = 1;
            foreach (string modifyInstanceAttributeRequestGroupId in modifyInstanceAttributeRequestGroupIdList)
            {
                parameters[String.Concat("GroupId", ".", modifyInstanceAttributeRequestGroupIdListIndex)] = modifyInstanceAttributeRequestGroupId;
                modifyInstanceAttributeRequestGroupIdListIndex++;
            }

            return parameters;
        }

        /**
         * Convert ModifySnapshotAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ModifySnapshotAttribute";
            if (request.IsSetSnapshotId())
            {
                parameters["SnapshotId"] = request.SnapshotId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }
            if (request.IsSetOperationType())
            {
                parameters["OperationType"] = request.OperationType;
            }
            List<string> modifySnapshotAttributeRequestUserIdList = request.UserId;
            int modifySnapshotAttributeRequestUserIdListIndex = 1;
            foreach (string modifySnapshotAttributeRequestUserId in modifySnapshotAttributeRequestUserIdList)
            {
                parameters[String.Concat("UserId", ".", modifySnapshotAttributeRequestUserIdListIndex)] = modifySnapshotAttributeRequestUserId;
                modifySnapshotAttributeRequestUserIdListIndex++;
            }
            List<string> modifySnapshotAttributeRequestUserGroupList = request.UserGroup;
            int modifySnapshotAttributeRequestUserGroupListIndex = 1;
            foreach (string modifySnapshotAttributeRequestUserGroup in modifySnapshotAttributeRequestUserGroupList)
            {
                parameters[String.Concat("UserGroup", ".", modifySnapshotAttributeRequestUserGroupListIndex)] = modifySnapshotAttributeRequestUserGroup;
                modifySnapshotAttributeRequestUserGroupListIndex++;
            }

            return parameters;
        }

        /**
         * Convert MonitorInstancesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertMonitorInstances(MonitorInstancesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "MonitorInstances";
            List<string> monitorInstancesRequestInstanceIdList = request.InstanceId;
            int monitorInstancesRequestInstanceIdListIndex = 1;
            foreach (string monitorInstancesRequestInstanceId in monitorInstancesRequestInstanceIdList)
            {
                parameters[String.Concat("InstanceId", ".", monitorInstancesRequestInstanceIdListIndex)] = monitorInstancesRequestInstanceId;
                monitorInstancesRequestInstanceIdListIndex++;
            }

            return parameters;
        }

        /**
         * Convert UnmonitorInstancesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertUnmonitorInstances(UnmonitorInstancesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "UnmonitorInstances";
            List<string> unmonitorInstancesRequestInstanceIdList = request.InstanceId;
            int unmonitorInstancesRequestInstanceIdListIndex = 1;
            foreach (string unmonitorInstancesRequestInstanceId in unmonitorInstancesRequestInstanceIdList)
            {
                parameters[String.Concat("InstanceId", ".", unmonitorInstancesRequestInstanceIdListIndex)] = unmonitorInstancesRequestInstanceId;
                unmonitorInstancesRequestInstanceIdListIndex++;
            }

            return parameters;
        }

        /**
         * Convert RebootInstancesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRebootInstances(RebootInstancesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "RebootInstances";
            List<string> rebootInstancesRequestInstanceIdList = request.InstanceId;
            int rebootInstancesRequestInstanceIdListIndex = 1;
            foreach (string rebootInstancesRequestInstanceId in rebootInstancesRequestInstanceIdList)
            {
                parameters[String.Concat("InstanceId", ".", rebootInstancesRequestInstanceIdListIndex)] = rebootInstancesRequestInstanceId;
                rebootInstancesRequestInstanceIdListIndex++;
            }

            return parameters;
        }

        /**
         * Convert RegisterImageRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRegisterImage(RegisterImageRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "RegisterImage";
            if (request.IsSetImageLocation())
            {
                parameters["ImageLocation"] = request.ImageLocation;
            }
            if (request.IsSetName())
            {
                parameters["Name"] = request.Name;
            }
            if (request.IsSetDescription())
            {
                parameters["Description"] = request.Description;
            }
            if (request.IsSetArchitecture())
            {
                parameters["Architecture"] = request.Architecture;
            }
            if (request.IsSetKernelId())
            {
                parameters["KernelId"] = request.KernelId;
            }
            if (request.IsSetRamdiskId())
            {
                parameters["RamdiskId"] = request.RamdiskId;
            }
            if (request.IsSetRootDeviceName())
            {
                parameters["RootDeviceName"] = request.RootDeviceName;
            }
            List<BlockDeviceMapping> registerImageRequestBlockDeviceMappingList = request.BlockDeviceMapping;
            int registerImageRequestBlockDeviceMappingListIndex = 1;
            foreach (BlockDeviceMapping registerImageRequestBlockDeviceMapping in registerImageRequestBlockDeviceMappingList)
            {
                if (registerImageRequestBlockDeviceMapping.IsSetDeviceName())
                {
                    parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "DeviceName")] = registerImageRequestBlockDeviceMapping.DeviceName;
                }
                if (registerImageRequestBlockDeviceMapping.IsSetVirtualName())
                {
                    parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "VirtualName")] = registerImageRequestBlockDeviceMapping.VirtualName;
                }
                if (registerImageRequestBlockDeviceMapping.IsSetEbs())
                {
                    EbsBlockDevice blockDeviceMappingEbs = registerImageRequestBlockDeviceMapping.Ebs;
                    if (blockDeviceMappingEbs.IsSetSnapshotId())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "SnapshotId")] = blockDeviceMappingEbs.SnapshotId;
                    }
                    if (blockDeviceMappingEbs.IsSetVolumeSize())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "VolumeSize")] = blockDeviceMappingEbs.VolumeSize.ToString();
                    }
                    if (blockDeviceMappingEbs.IsSetDeleteOnTermination())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "DeleteOnTermination")] = blockDeviceMappingEbs.DeleteOnTermination.ToString().ToLower();
                    }
                    if (blockDeviceMappingEbs.IsSetVolumeType())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "VolumeType")] = blockDeviceMappingEbs.VolumeType;
                    }
                    if (blockDeviceMappingEbs.IsSetIOPS())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "Iops")] = blockDeviceMappingEbs.IOPS;
                    }
                }
                if (registerImageRequestBlockDeviceMapping.IsSetNoDevice())
                {
                    parameters[String.Concat("BlockDeviceMapping", ".", registerImageRequestBlockDeviceMappingListIndex, ".", "NoDevice")] = registerImageRequestBlockDeviceMapping.NoDevice;
                }

                registerImageRequestBlockDeviceMappingListIndex++;
            }

            return parameters;
        }

        /**
         * Convert ReleaseAddressRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertReleaseAddress(ReleaseAddressRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ReleaseAddress";
            if (request.IsSetPublicIp())
            {
                parameters["PublicIp"] = request.PublicIp;
            }
            if (request.IsSetAllocationId())
            {
                parameters["AllocationId"] = request.AllocationId;
            }

            return parameters;
        }

        /**
         * Convert ResetImageAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertResetImageAttribute(ResetImageAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ResetImageAttribute";
            if (request.IsSetImageId())
            {
                parameters["ImageId"] = request.ImageId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }

            return parameters;
        }

        /**
         * Convert ResetInstanceAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertResetInstanceAttribute(ResetInstanceAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ResetInstanceAttribute";
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }

            return parameters;
        }

        /**
         * Convert ResetSnapshotAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertResetSnapshotAttribute(ResetSnapshotAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ResetSnapshotAttribute";
            if (request.IsSetSnapshotId())
            {
                parameters["SnapshotId"] = request.SnapshotId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }

            return parameters;
        }

        /**
         * Convert RevokeSecurityGroupIngressRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "RevokeSecurityGroupIngress";
            if (request.IsSetUserId())
            {
                parameters["UserId"] = request.UserId;
            }
            if (request.IsSetGroupName())
            {
                parameters["GroupName"] = request.GroupName;
            }
            if (request.IsSetGroupId())
            {
                parameters["GroupId"] = request.GroupId;
            } 
            if (request.IsSetSourceSecurityGroupName())
            {
                parameters["SourceSecurityGroupName"] = request.SourceSecurityGroupName;
            }
            if (request.IsSetSourceSecurityGroupOwnerId())
            {
                parameters["SourceSecurityGroupOwnerId"] = request.SourceSecurityGroupOwnerId;
            }
            if (request.IsSetIpProtocol())
            {
                parameters["IpProtocol"] = request.IpProtocol;
            }
            if (request.IsSetFromPort())
            {
                parameters["FromPort"] = request.FromPort.ToString();
            }
            if (request.IsSetToPort())
            {
                parameters["ToPort"] = request.ToPort.ToString();
            }
            if (request.IsSetCidrIp())
            {
                parameters["CidrIp"] = request.CidrIp;
            }
            List<IpPermissionSpecification> revokeSecurityGroupIngressRequestIpPermissionsList = request.IpPermissions;
            int revokeSecurityGroupIngressRequestIpPermissionsListIndex = 1;
            foreach (IpPermissionSpecification revokeSecurityGroupIngressRequestIpPermissions in revokeSecurityGroupIngressRequestIpPermissionsList)
            {
                if (revokeSecurityGroupIngressRequestIpPermissions.IsSetIpProtocol())
                {
                    parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "IpProtocol")] = revokeSecurityGroupIngressRequestIpPermissions.IpProtocol;
                }
                if (revokeSecurityGroupIngressRequestIpPermissions.IsSetFromPort())
                {
                    parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "FromPort")] = revokeSecurityGroupIngressRequestIpPermissions.FromPort.ToString();
                }
                if (revokeSecurityGroupIngressRequestIpPermissions.IsSetToPort())
                {
                    parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "ToPort")] = revokeSecurityGroupIngressRequestIpPermissions.ToPort.ToString();
                }
                List<UserIdGroupPair> ipPermissionsGroupsList = revokeSecurityGroupIngressRequestIpPermissions.Groups;
                int ipPermissionsGroupsListIndex = 1;
                foreach (UserIdGroupPair ipPermissionsGroups in ipPermissionsGroupsList)
                {
                    if (ipPermissionsGroups.IsSetUserId())
                    {
                        parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "Groups", ".", ipPermissionsGroupsListIndex, ".", "UserId")] = ipPermissionsGroups.UserId;
                    }
                    if (ipPermissionsGroups.IsSetGroupId())
                    {
                        parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "Groups", ".", ipPermissionsGroupsListIndex, ".", "GroupId")] = ipPermissionsGroups.GroupId;
                    }
                    if (ipPermissionsGroups.IsSetGroupName())
                    {
                        parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "Groups", ".", ipPermissionsGroupsListIndex, ".", "GroupName")] = ipPermissionsGroups.GroupName;
                    }

                    ipPermissionsGroupsListIndex++;
                }
                List<string> ipPermissionsIpRangesList = revokeSecurityGroupIngressRequestIpPermissions.IpRanges;
                int ipPermissionsIpRangesListIndex = 1;
                foreach (string ipPermissionsIpRanges in ipPermissionsIpRangesList)
                {
                    parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupIngressRequestIpPermissionsListIndex, ".", "IpRanges", ".", ipPermissionsIpRangesListIndex, ".CidrIp")] = ipPermissionsIpRanges;
                    ipPermissionsIpRangesListIndex++;
                }

                revokeSecurityGroupIngressRequestIpPermissionsListIndex++;
            }

            return parameters;
        }

        /**
         * Convert RunInstancesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRunInstances(RunInstancesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "RunInstances";
            if (request.IsSetImageId())
            {
                parameters["ImageId"] = request.ImageId;
            }
            if (request.IsSetMinCount())
            {
                parameters["MinCount"] = request.MinCount.ToString();
            }
            if (request.IsSetMaxCount())
            {
                parameters["MaxCount"] = request.MaxCount.ToString();
            }
            if (request.IsSetKeyName())
            {
                parameters["KeyName"] = request.KeyName;
            }
            List<string> runInstancesRequestSecurityGroupList = request.SecurityGroup;
            int runInstancesRequestSecurityGroupListIndex = 1;
            foreach (string runInstancesRequestSecurityGroup in runInstancesRequestSecurityGroupList)
            {
                parameters[String.Concat("SecurityGroup", ".", runInstancesRequestSecurityGroupListIndex)] = runInstancesRequestSecurityGroup;
                runInstancesRequestSecurityGroupListIndex++;
            }
            List<string> runInstancesRequestSecurityGroupIdList = request.SecurityGroupId;
            int runInstancesRequestSecurityGroupIdListIndex = 1;
            foreach (string runInstancesRequestSecurityGroupId in runInstancesRequestSecurityGroupIdList)
            {
                parameters[String.Concat("SecurityGroupId", ".", runInstancesRequestSecurityGroupIdListIndex)] = runInstancesRequestSecurityGroupId;
                runInstancesRequestSecurityGroupIdListIndex++;
            }
            if (request.IsSetUserData())
            {
                parameters["UserData"] = request.UserData;
            }
            if (request.IsSetInstanceType())
            {
                parameters["InstanceType"] = request.InstanceType;
            }
            if (request.IsSetPlacement())
            {
                Placement runInstancesRequestPlacement = request.Placement;
                if (runInstancesRequestPlacement.IsSetAvailabilityZone())
                {
                    parameters[String.Concat("Placement", ".", "AvailabilityZone")] = runInstancesRequestPlacement.AvailabilityZone;
                }
                if (runInstancesRequestPlacement.IsSetGroupName())
                {
                    parameters[String.Concat("Placement", ".", "GroupName")] = runInstancesRequestPlacement.GroupName;
                }
                if (runInstancesRequestPlacement.IsSetTenancy())
                {
                    parameters[String.Concat("Placement", ".", "Tenancy")] = runInstancesRequestPlacement.Tenancy;
                }
            }
            if (request.IsSetKernelId())
            {
                parameters["KernelId"] = request.KernelId;
            }
            if (request.IsSetRamdiskId())
            {
                parameters["RamdiskId"] = request.RamdiskId;
            }
            List<BlockDeviceMapping> runInstancesRequestBlockDeviceMappingList = request.BlockDeviceMapping;
            int runInstancesRequestBlockDeviceMappingListIndex = 1;
            foreach (BlockDeviceMapping runInstancesRequestBlockDeviceMapping in runInstancesRequestBlockDeviceMappingList)
            {
                if (runInstancesRequestBlockDeviceMapping.IsSetDeviceName())
                {
                    parameters[String.Concat("BlockDeviceMapping", ".", runInstancesRequestBlockDeviceMappingListIndex, ".", "DeviceName")] = runInstancesRequestBlockDeviceMapping.DeviceName;
                }
                if (runInstancesRequestBlockDeviceMapping.IsSetVirtualName())
                {
                    parameters[String.Concat("BlockDeviceMapping", ".", runInstancesRequestBlockDeviceMappingListIndex, ".", "VirtualName")] = runInstancesRequestBlockDeviceMapping.VirtualName;
                }
                if (runInstancesRequestBlockDeviceMapping.IsSetEbs())
                {
                    EbsBlockDevice blockDeviceMappingEbs = runInstancesRequestBlockDeviceMapping.Ebs;
                    if (blockDeviceMappingEbs.IsSetSnapshotId())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", runInstancesRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "SnapshotId")] = blockDeviceMappingEbs.SnapshotId;
                    }
                    if (blockDeviceMappingEbs.IsSetVolumeSize())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", runInstancesRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "VolumeSize")] = blockDeviceMappingEbs.VolumeSize.ToString();
                    }
                    if (blockDeviceMappingEbs.IsSetDeleteOnTermination())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", runInstancesRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "DeleteOnTermination")] = blockDeviceMappingEbs.DeleteOnTermination.ToString().ToLower();
                    }
                    if (blockDeviceMappingEbs.IsSetVolumeType())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", runInstancesRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "VolumeType")] = blockDeviceMappingEbs.VolumeType;
                    }
                    if (blockDeviceMappingEbs.IsSetIOPS())
                    {
                        parameters[String.Concat("BlockDeviceMapping", ".", runInstancesRequestBlockDeviceMappingListIndex, ".", "Ebs", ".", "Iops")] = blockDeviceMappingEbs.IOPS;
                    }
                }
                if (runInstancesRequestBlockDeviceMapping.IsSetNoDevice())
                {
                    parameters[String.Concat("BlockDeviceMapping", ".", runInstancesRequestBlockDeviceMappingListIndex, ".", "NoDevice")] = runInstancesRequestBlockDeviceMapping.NoDevice;
                }

                runInstancesRequestBlockDeviceMappingListIndex++;
            }
            if (request.IsSetMonitoring())
            {
                MonitoringSpecification runInstancesRequestMonitoring = request.Monitoring;
                if (runInstancesRequestMonitoring.IsSetEnabled())
                {
                    parameters[String.Concat("Monitoring", ".", "Enabled")] = runInstancesRequestMonitoring.Enabled.ToString().ToLower();
                }
            }
            if (request.IsSetSubnetId())
            {
                parameters["SubnetId"] = request.SubnetId;
            }
            if (request.IsSetDisableApiTermination())
            {
                parameters["DisableApiTermination"] = request.DisableApiTermination.ToString().ToLower();
            }
            if (request.IsSetInstanceInitiatedShutdownBehavior())
            {
                parameters["InstanceInitiatedShutdownBehavior"] = request.InstanceInitiatedShutdownBehavior;
            }
            if (request.IsSetLicense())
            {
                InstanceLicenseSpecification runInstancesRequestLicense = request.License;
                if (runInstancesRequestLicense.IsSetPool())
                {
                    parameters[String.Concat("License", ".", "Pool")] = runInstancesRequestLicense.Pool;
                }
            }
            if (request.IsSetPrivateIpAddress())
            {
                parameters["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (request.IsSetClientToken())
            {
                parameters["ClientToken"] = request.ClientToken;
            }
            if (request.IsSetNetworkInterfaceSet())
            {
                List<InstanceNetworkInterfaceSpecification> instanceNetworkInterfaceList = request.NetworkInterfaceSet;
                int instanceNetworkInterfaceListIndex = 1;
                foreach (InstanceNetworkInterfaceSpecification instanceNetworkInterface in instanceNetworkInterfaceList)
                {
                    if (instanceNetworkInterface.IsSetNetworkInterfaceId())
                    {
                        parameters[String.Concat("NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "NetworkInterfaceId")] = instanceNetworkInterface.NetworkInterfaceId;
                    }
                    if (instanceNetworkInterface.IsSetDeviceIndex())
                    {
                        parameters[String.Concat("NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "DeviceIndex")] = instanceNetworkInterface.DeviceIndex.ToString();
                    }
                    if (instanceNetworkInterface.IsSetSubnetId())
                    {
                        parameters[String.Concat("NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "SubnetId")] = instanceNetworkInterface.SubnetId;
                    }
                    if (instanceNetworkInterface.IsSetDescription())
                    {
                        parameters[String.Concat("NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "Description")] = instanceNetworkInterface.Description;
                    }
                    if (instanceNetworkInterface.IsSetPrivateIpAddress())
                    {
                        parameters[String.Concat("NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "PrivateIpAddress")] = instanceNetworkInterface.PrivateIpAddress;
                    }
                    if (instanceNetworkInterface.IsSetDeleteOnTermination())
                    {
                        parameters[String.Concat("NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "DeleteOnTermination")] = instanceNetworkInterface.DeleteOnTermination.ToString();
                    }
                    if (instanceNetworkInterface.IsSetGroupId())
                    {
                        List<string> groupIdList = instanceNetworkInterface.GroupId;
                        int groupIdIndex = 1;
                        foreach (string groupId in groupIdList)
                        {
                            parameters[String.Concat("NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "SecurityGroupId", ".", groupIdIndex)] = groupId;
                            groupIdIndex++;
                        }
                    }

                    if (instanceNetworkInterface.IsSetPrivateIpAddresses())
                    {
                        List<PrivateIpAddress> privateIpAddressesList = instanceNetworkInterface.PrivateIpAddresses;
                        int privateIpAddressesListIndex = 1;
                        foreach (PrivateIpAddress privateIpAddress in privateIpAddressesList)
                        {
                            parameters[String.Concat("NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "PrivateIpAddresses", ".", privateIpAddressesListIndex, ".", "Primary")] = privateIpAddress.Primary.ToString().ToLower();
                            parameters[String.Concat("NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "PrivateIpAddresses", ".", privateIpAddressesListIndex, ".", "PrivateIpAddress")] = privateIpAddress.IpAddress;
                            privateIpAddressesListIndex++;
                        }
                    }

                    if (instanceNetworkInterface.IsSetSecondaryPrivateIpAddressCount())
                    {
                        parameters[String.Concat("NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "SecondaryPrivateIpAddressCount")] = instanceNetworkInterface.SecondaryPrivateIpAddressCount.ToString();
                    }

                    instanceNetworkInterfaceListIndex++;
                }
            }
            if (request.IsSetEbsOptimized())
            {
                parameters["EbsOptimized"] = request.EbsOptimized.ToString().ToLower();
            }
            if (request.IsSetInstanceProfile())
            {
                IAMInstanceProfile instanceProfile = request.InstanceProfile;
                if (instanceProfile.IsSetArn())
                {
                    parameters[String.Concat("IamInstanceProfile", ".", "Arn")] = instanceProfile.Arn;
                }
            }

            return parameters;
        }

        /**
         * Convert StopInstancesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertStopInstances(StopInstancesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "StopInstances";
            List<string> stopInstancesRequestInstanceIdList = request.InstanceId;
            int stopInstancesRequestInstanceIdListIndex = 1;
            foreach (string stopInstancesRequestInstanceId in stopInstancesRequestInstanceIdList)
            {
                parameters[String.Concat("InstanceId", ".", stopInstancesRequestInstanceIdListIndex)] = stopInstancesRequestInstanceId;
                stopInstancesRequestInstanceIdListIndex++;
            }
            if (request.IsSetForce())
            {
                parameters["Force"] = request.Force.ToString().ToLower();
            }

            return parameters;
        }

        /**
         * Convert StartInstancesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertStartInstances(StartInstancesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "StartInstances";
            List<string> startInstancesRequestInstanceIdList = request.InstanceId;
            int startInstancesRequestInstanceIdListIndex = 1;
            foreach (string startInstancesRequestInstanceId in startInstancesRequestInstanceIdList)
            {
                parameters[String.Concat("InstanceId", ".", startInstancesRequestInstanceIdListIndex)] = startInstancesRequestInstanceId;
                startInstancesRequestInstanceIdListIndex++;
            }

            return parameters;
        }

        /**
         * Convert TerminateInstancesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertTerminateInstances(TerminateInstancesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "TerminateInstances";
            List<string> terminateInstancesRequestInstanceIdList = request.InstanceId;
            int terminateInstancesRequestInstanceIdListIndex = 1;
            foreach (string terminateInstancesRequestInstanceId in terminateInstancesRequestInstanceIdList)
            {
                parameters[String.Concat("InstanceId", ".", terminateInstancesRequestInstanceIdListIndex)] = terminateInstancesRequestInstanceId;
                terminateInstancesRequestInstanceIdListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DeleteVolumeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteVolume(DeleteVolumeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteVolume";
            if (request.IsSetVolumeId())
            {
                parameters["VolumeId"] = request.VolumeId;
            }

            return parameters;
        }

        /**
         * Convert CreateVolumeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateVolume(CreateVolumeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateVolume";
            if (request.IsSetSize())
            {
                parameters["Size"] = request.Size;
            }
            if (request.IsSetSnapshotId())
            {
                parameters["SnapshotId"] = request.SnapshotId;
            }
            if (request.IsSetAvailabilityZone())
            {
                parameters["AvailabilityZone"] = request.AvailabilityZone;
            }
            if (request.IsSetIOPS())
            {
                parameters["Iops"] = request.IOPS;
            }
            if (request.IsSetVolumeType())
            {
                parameters["VolumeType"] = request.VolumeType;
            }

            return parameters;
        }

        /**
         * Convert DescribeVolumesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeVolumes(DescribeVolumesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeVolumes";
            List<string> describeVolumesRequestVolumeIdList = request.VolumeId;
            int describeVolumesRequestVolumeIdListIndex = 1;
            foreach (string describeVolumesRequestVolumeId in describeVolumesRequestVolumeIdList)
            {
                parameters[String.Concat("VolumeId", ".", describeVolumesRequestVolumeIdListIndex)] = describeVolumesRequestVolumeId;
                describeVolumesRequestVolumeIdListIndex++;
            }
            List<Filter> describeVolumesRequestFilterList = request.Filter;
            int describeVolumesRequestFilterListIndex = 1;
            foreach (Filter describeVolumesRequestFilter in describeVolumesRequestFilterList)
            {
                if (describeVolumesRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeVolumesRequestFilterListIndex, ".", "Name")] = describeVolumesRequestFilter.Name;
                }
                List<string> filterValueList = describeVolumesRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeVolumesRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeVolumesRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DetachVolumeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDetachVolume(DetachVolumeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DetachVolume";
            if (request.IsSetVolumeId())
            {
                parameters["VolumeId"] = request.VolumeId;
            }
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }
            if (request.IsSetDevice())
            {
                parameters["Device"] = request.Device;
            }
            if (request.IsSetForce())
            {
                parameters["Force"] = request.Force.ToString().ToLower();
            }

            return parameters;
        }

        /**
         * Convert DetachVpnGatewayRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDetachVpnGateway(DetachVpnGatewayRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DetachVpnGateway";
            if (request.IsSetVpnGatewayId())
            {
                parameters["VpnGatewayId"] = request.VpnGatewayId;
            }
            if (request.IsSetVpcId())
            {
                parameters["VpcId"] = request.VpcId;
            }

            return parameters;
        }

        /**
         * Convert DescribeSnapshotsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeSnapshots(DescribeSnapshotsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeSnapshots";
            List<string> describeSnapshotsRequestSnapshotIdList = request.SnapshotId;
            int describeSnapshotsRequestSnapshotIdListIndex = 1;
            foreach (string describeSnapshotsRequestSnapshotId in describeSnapshotsRequestSnapshotIdList)
            {
                parameters[String.Concat("SnapshotId", ".", describeSnapshotsRequestSnapshotIdListIndex)] = describeSnapshotsRequestSnapshotId;
                describeSnapshotsRequestSnapshotIdListIndex++;
            }
            if (request.IsSetOwner())
            {
                parameters["Owner"] = request.Owner;
            }
            if (request.IsSetRestorableBy())
            {
                parameters["RestorableBy"] = request.RestorableBy;
            }
            List<Filter> describeSnapshotsRequestFilterList = request.Filter;
            int describeSnapshotsRequestFilterListIndex = 1;
            foreach (Filter describeSnapshotsRequestFilter in describeSnapshotsRequestFilterList)
            {
                if (describeSnapshotsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeSnapshotsRequestFilterListIndex, ".", "Name")] = describeSnapshotsRequestFilter.Name;
                }
                List<string> filterValueList = describeSnapshotsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeSnapshotsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeSnapshotsRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DeleteSnapshotRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteSnapshot(DeleteSnapshotRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteSnapshot";
            if (request.IsSetSnapshotId())
            {
                parameters["SnapshotId"] = request.SnapshotId;
            }

            return parameters;
        }

        /**
         * Convert CreateSnapshotRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateSnapshot(CreateSnapshotRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateSnapshot";
            if (request.IsSetVolumeId())
            {
                parameters["VolumeId"] = request.VolumeId;
            }
            if (request.IsSetDescription())
            {
                parameters["Description"] = request.Description;
            }

            return parameters;
        }

        /**
         * Convert AttachVolumeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAttachVolume(AttachVolumeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AttachVolume";
            if (request.IsSetVolumeId())
            {
                parameters["VolumeId"] = request.VolumeId;
            }
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }
            if (request.IsSetDevice())
            {
                parameters["Device"] = request.Device;
            }

            return parameters;
        }

        /**
         * Convert DescribeRegionsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeRegions(DescribeRegionsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeRegions";
            List<string> describeRegionsRequestRegionNameList = request.RegionName;
            int describeRegionsRequestRegionNameListIndex = 1;
            foreach (string describeRegionsRequestRegionName in describeRegionsRequestRegionNameList)
            {
                parameters[String.Concat("RegionName", ".", describeRegionsRequestRegionNameListIndex)] = describeRegionsRequestRegionName;
                describeRegionsRequestRegionNameListIndex++;
            }
            List<Filter> describeRegionsRequestFilterList = request.Filter;
            int describeRegionsRequestFilterListIndex = 1;
            foreach (Filter describeRegionsRequestFilter in describeRegionsRequestFilterList)
            {
                if (describeRegionsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeRegionsRequestFilterListIndex, ".", "Name")] = describeRegionsRequestFilter.Name;
                }
                List<string> filterValueList = describeRegionsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeRegionsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeRegionsRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert RequestSpotInstancesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRequestSpotInstances(RequestSpotInstancesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "RequestSpotInstances";
            if (request.IsSetSpotPrice())
            {
                parameters["SpotPrice"] = request.SpotPrice;
            }
            if (request.IsSetInstanceCount())
            {
                parameters["InstanceCount"] = request.InstanceCount.ToString();
            }
            if (request.IsSetType())
            {
                parameters["Type"] = request.Type;
            }
            if (request.IsSetValidFrom())
            {
                parameters["ValidFrom"] = request.ValidFrom;
            }
            if (request.IsSetValidUntil())
            {
                parameters["ValidUntil"] = request.ValidUntil;
            }
            if (request.IsSetLaunchGroup())
            {
                parameters["LaunchGroup"] = request.LaunchGroup;
            }
            if (request.IsSetAvailabilityZoneGroup())
            {
                parameters["AvailabilityZoneGroup"] = request.AvailabilityZoneGroup;
            }
            if (request.IsSetLaunchSpecification())
            {
                LaunchSpecification requestSpotInstancesRequestLaunchSpecification = request.LaunchSpecification;
                if (requestSpotInstancesRequestLaunchSpecification.IsSetImageId())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "ImageId")] = requestSpotInstancesRequestLaunchSpecification.ImageId;
                }
                if (requestSpotInstancesRequestLaunchSpecification.IsSetKeyName())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "KeyName")] = requestSpotInstancesRequestLaunchSpecification.KeyName;
                }
                List<string> launchSpecificationSecurityGroupList = requestSpotInstancesRequestLaunchSpecification.SecurityGroup;
                int launchSpecificationSecurityGroupListIndex = 1;
                foreach (string launchSpecificationSecurityGroup in launchSpecificationSecurityGroupList)
                {
                    parameters[String.Concat("LaunchSpecification", ".", "SecurityGroup", ".", launchSpecificationSecurityGroupListIndex)] = launchSpecificationSecurityGroup;
                    launchSpecificationSecurityGroupListIndex++;
                }
                List<string> launchSpecificationSecurityGroupIdList = requestSpotInstancesRequestLaunchSpecification.SecurityGroupId;
                int launchSpecificationSecurityGroupIdListIndex = 1;
                foreach (string launchSpecificationSecurityGroupId in launchSpecificationSecurityGroupIdList)
                {
                    parameters[String.Concat("LaunchSpecification", ".", "SecurityGroupId", ".", launchSpecificationSecurityGroupIdListIndex)] = launchSpecificationSecurityGroupId;
                    launchSpecificationSecurityGroupIdListIndex++;
                }
                if (requestSpotInstancesRequestLaunchSpecification.IsSetUserData())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "UserData")] = requestSpotInstancesRequestLaunchSpecification.UserData;
                }
                if (requestSpotInstancesRequestLaunchSpecification.IsSetAddressingType())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "AddressingType")] = requestSpotInstancesRequestLaunchSpecification.AddressingType;
                }
                if (requestSpotInstancesRequestLaunchSpecification.IsSetInstanceType())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "InstanceType")] = requestSpotInstancesRequestLaunchSpecification.InstanceType;
                }
                if (requestSpotInstancesRequestLaunchSpecification.IsSetPlacement())
                {
                    Placement launchSpecificationPlacement = requestSpotInstancesRequestLaunchSpecification.Placement;
                    if (launchSpecificationPlacement.IsSetAvailabilityZone())
                    {
                        parameters[String.Concat("LaunchSpecification", ".", "Placement", ".", "AvailabilityZone")] = launchSpecificationPlacement.AvailabilityZone;
                    }
                    if (launchSpecificationPlacement.IsSetGroupName())
                    {
                        parameters[String.Concat("LaunchSpecification", ".", "Placement", ".", "GroupName")] = launchSpecificationPlacement.GroupName;
                    }
                    if (launchSpecificationPlacement.IsSetTenancy())
                    {
                        parameters[String.Concat("LaunchSpecification", ".", "Placement", ".", "Tenancy")] = launchSpecificationPlacement.Tenancy;
                    }
                }
                if (requestSpotInstancesRequestLaunchSpecification.IsSetKernelId())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "KernelId")] = requestSpotInstancesRequestLaunchSpecification.KernelId;
                }
                if (requestSpotInstancesRequestLaunchSpecification.IsSetRamdiskId())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "RamdiskId")] = requestSpotInstancesRequestLaunchSpecification.RamdiskId;
                }
                List<BlockDeviceMapping> launchSpecificationBlockDeviceMappingList = requestSpotInstancesRequestLaunchSpecification.BlockDeviceMapping;
                int launchSpecificationBlockDeviceMappingListIndex = 1;
                foreach (BlockDeviceMapping launchSpecificationBlockDeviceMapping in launchSpecificationBlockDeviceMappingList)
                {
                    if (launchSpecificationBlockDeviceMapping.IsSetDeviceName())
                    {
                        parameters[String.Concat("LaunchSpecification", ".", "BlockDeviceMapping", ".", launchSpecificationBlockDeviceMappingListIndex, ".", "DeviceName")] = launchSpecificationBlockDeviceMapping.DeviceName;
                    }
                    if (launchSpecificationBlockDeviceMapping.IsSetVirtualName())
                    {
                        parameters[String.Concat("LaunchSpecification", ".", "BlockDeviceMapping", ".", launchSpecificationBlockDeviceMappingListIndex, ".", "VirtualName")] = launchSpecificationBlockDeviceMapping.VirtualName;
                    }
                    if (launchSpecificationBlockDeviceMapping.IsSetEbs())
                    {
                        EbsBlockDevice blockDeviceMappingEbs = launchSpecificationBlockDeviceMapping.Ebs;
                        if (blockDeviceMappingEbs.IsSetSnapshotId())
                        {
                            parameters[String.Concat("LaunchSpecification", ".", "BlockDeviceMapping", ".", launchSpecificationBlockDeviceMappingListIndex, ".", "Ebs", ".", "SnapshotId")] = blockDeviceMappingEbs.SnapshotId;
                        }
                        if (blockDeviceMappingEbs.IsSetVolumeSize())
                        {
                            parameters[String.Concat("LaunchSpecification", ".", "BlockDeviceMapping", ".", launchSpecificationBlockDeviceMappingListIndex, ".", "Ebs", ".", "VolumeSize")] = blockDeviceMappingEbs.VolumeSize.ToString();
                        }
                        if (blockDeviceMappingEbs.IsSetDeleteOnTermination())
                        {
                            parameters[String.Concat("LaunchSpecification", ".", "BlockDeviceMapping", ".", launchSpecificationBlockDeviceMappingListIndex, ".", "Ebs", ".", "DeleteOnTermination")] = blockDeviceMappingEbs.DeleteOnTermination.ToString().ToLower();
                        }
                        if (blockDeviceMappingEbs.IsSetVolumeType())
                        {
                            parameters[String.Concat("LaunchSpecification", ".", "BlockDeviceMapping", ".", launchSpecificationBlockDeviceMappingListIndex, ".", "Ebs", ".", "VolumeType")] = blockDeviceMappingEbs.VolumeType;
                        }
                        if (blockDeviceMappingEbs.IsSetIOPS())
                        {
                            parameters[String.Concat("LaunchSpecification", ".", "BlockDeviceMapping", ".", launchSpecificationBlockDeviceMappingListIndex, ".", "Ebs", ".", "Iops")] = blockDeviceMappingEbs.IOPS;
                        }
                    }
                    if (launchSpecificationBlockDeviceMapping.IsSetNoDevice())
                    {
                        parameters[String.Concat("LaunchSpecification", ".", "BlockDeviceMapping", ".", launchSpecificationBlockDeviceMappingListIndex, ".", "NoDevice")] = launchSpecificationBlockDeviceMapping.NoDevice;
                    }

                    launchSpecificationBlockDeviceMappingListIndex++;
                }
                if (requestSpotInstancesRequestLaunchSpecification.IsSetMonitoring())
                {
                    MonitoringSpecification launchSpecificationMonitoring = requestSpotInstancesRequestLaunchSpecification.Monitoring;
                    if (launchSpecificationMonitoring.IsSetEnabled())
                    {
                        parameters[String.Concat("LaunchSpecification", ".", "Monitoring", ".", "Enabled")] = launchSpecificationMonitoring.Enabled.ToString().ToLower();
                    }
                }
                if (requestSpotInstancesRequestLaunchSpecification.IsSetSubnetId())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "SubnetId")] = requestSpotInstancesRequestLaunchSpecification.SubnetId;
                }
                if (requestSpotInstancesRequestLaunchSpecification.IsSetNetworkInterfaceSet())
                {
                    List<InstanceNetworkInterfaceSpecification> instanceNetworkInterfaceList = requestSpotInstancesRequestLaunchSpecification.NetworkInterfaceSet;
                    int instanceNetworkInterfaceListIndex = 1;
                    foreach (InstanceNetworkInterfaceSpecification instanceNetworkInterface in instanceNetworkInterfaceList)
                    {
                        if (instanceNetworkInterface.IsSetNetworkInterfaceId())
                        {
                            parameters[String.Concat("LaunchSpecification", ".", "NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "NetworkInterfaceId")] = instanceNetworkInterface.NetworkInterfaceId;
                        }
                        if (instanceNetworkInterface.IsSetDeviceIndex())
                        {
                            parameters[String.Concat("LaunchSpecification", ".", "NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "DeviceIndex")] = instanceNetworkInterface.DeviceIndex.ToString();
                        }
                        if (instanceNetworkInterface.IsSetSubnetId())
                        {
                            parameters[String.Concat("LaunchSpecification", ".", "NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "SubnetId")] = instanceNetworkInterface.SubnetId;
                        }
                        if (instanceNetworkInterface.IsSetDescription())
                        {
                            parameters[String.Concat("LaunchSpecification", ".", "NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "Description")] = instanceNetworkInterface.Description;
                        }
                        if (instanceNetworkInterface.IsSetPrivateIpAddress())
                        {
                            parameters[String.Concat("LaunchSpecification", ".", "NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "PrivateIpAddress")] = instanceNetworkInterface.PrivateIpAddress;
                        }
                        if (instanceNetworkInterface.IsSetDeleteOnTermination())
                        {
                            parameters[String.Concat("LaunchSpecification", ".", "NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "DeleteOnTermination")] = instanceNetworkInterface.DeleteOnTermination.ToString();
                        }
                        if (instanceNetworkInterface.IsSetGroupId())
                        {
                            List<string> groupIdList = instanceNetworkInterface.GroupId;
                            int groupIdIndex = 1;
                            foreach (string groupId in groupIdList)
                            {
                                parameters[String.Concat("LaunchSpecification", ".", "NetworkInterface", ".", instanceNetworkInterfaceListIndex, ".", "SecurityGroupId", ".", groupIdIndex)] = groupId;
                                groupIdIndex++;
                            }
                        }

                        instanceNetworkInterfaceListIndex++;
                    }
                }
                if (requestSpotInstancesRequestLaunchSpecification.IsSetInstanceProfile())
                {
                    IAMInstanceProfile instanceProfile = requestSpotInstancesRequestLaunchSpecification.InstanceProfile;
                    if (instanceProfile.IsSetArn())
                    {
                        parameters[String.Concat("LaunchSpecification", ".", "IamInstanceProfile", ".", "Arn")] = instanceProfile.Arn;
                    }
                }
                if (requestSpotInstancesRequestLaunchSpecification.IsSetEbsOptimized())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "EbsOptimized")] = requestSpotInstancesRequestLaunchSpecification.EbsOptimized.ToString().ToLower();
                }
            }

            return parameters;
        }

        /**
         * Convert DescribeSpotInstanceRequestsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeSpotInstanceRequests";
            List<string> describeSpotInstanceRequestsRequestSpotInstanceRequestIdList = request.SpotInstanceRequestId;
            int describeSpotInstanceRequestsRequestSpotInstanceRequestIdListIndex = 1;
            foreach (string describeSpotInstanceRequestsRequestSpotInstanceRequestId in describeSpotInstanceRequestsRequestSpotInstanceRequestIdList)
            {
                parameters[String.Concat("SpotInstanceRequestId", ".", describeSpotInstanceRequestsRequestSpotInstanceRequestIdListIndex)] = describeSpotInstanceRequestsRequestSpotInstanceRequestId;
                describeSpotInstanceRequestsRequestSpotInstanceRequestIdListIndex++;
            }
            List<Filter> describeSpotInstanceRequestsRequestFilterList = request.Filter;
            int describeSpotInstanceRequestsRequestFilterListIndex = 1;
            foreach (Filter describeSpotInstanceRequestsRequestFilter in describeSpotInstanceRequestsRequestFilterList)
            {
                if (describeSpotInstanceRequestsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeSpotInstanceRequestsRequestFilterListIndex, ".", "Name")] = describeSpotInstanceRequestsRequestFilter.Name;
                }
                List<string> filterValueList = describeSpotInstanceRequestsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeSpotInstanceRequestsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeSpotInstanceRequestsRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert CancelSpotInstanceRequestsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CancelSpotInstanceRequests";
            List<string> cancelSpotInstanceRequestsRequestSpotInstanceRequestIdList = request.SpotInstanceRequestId;
            int cancelSpotInstanceRequestsRequestSpotInstanceRequestIdListIndex = 1;
            foreach (string cancelSpotInstanceRequestsRequestSpotInstanceRequestId in cancelSpotInstanceRequestsRequestSpotInstanceRequestIdList)
            {
                parameters[String.Concat("SpotInstanceRequestId", ".", cancelSpotInstanceRequestsRequestSpotInstanceRequestIdListIndex)] = cancelSpotInstanceRequestsRequestSpotInstanceRequestId;
                cancelSpotInstanceRequestsRequestSpotInstanceRequestIdListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeSpotPriceHistoryRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeSpotPriceHistory";
            if (request.IsSetStartTime())
            {
                parameters["StartTime"] = request.StartTime;
            }
            if (request.IsSetEndTime())
            {
                parameters["EndTime"] = request.EndTime;
            }
            List<string> describeSpotPriceHistoryRequestInstanceTypeList = request.InstanceType;
            int describeSpotPriceHistoryRequestInstanceTypeListIndex = 1;
            foreach (string describeSpotPriceHistoryRequestInstanceType in describeSpotPriceHistoryRequestInstanceTypeList)
            {
                parameters[String.Concat("InstanceType", ".", describeSpotPriceHistoryRequestInstanceTypeListIndex)] = describeSpotPriceHistoryRequestInstanceType;
                describeSpotPriceHistoryRequestInstanceTypeListIndex++;
            }
            List<string> describeSpotPriceHistoryRequestProductDescriptionList = request.ProductDescription;
            int describeSpotPriceHistoryRequestProductDescriptionListIndex = 1;
            foreach (string describeSpotPriceHistoryRequestProductDescription in describeSpotPriceHistoryRequestProductDescriptionList)
            {
                parameters[String.Concat("ProductDescription", ".", describeSpotPriceHistoryRequestProductDescriptionListIndex)] = describeSpotPriceHistoryRequestProductDescription;
                describeSpotPriceHistoryRequestProductDescriptionListIndex++;
            }
            List<Filter> describeSpotPriceHistoryRequestFilterList = request.Filter;
            int describeSpotPriceHistoryRequestFilterListIndex = 1;
            foreach (Filter describeSpotPriceHistoryRequestFilter in describeSpotPriceHistoryRequestFilterList)
            {
                if (describeSpotPriceHistoryRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeSpotPriceHistoryRequestFilterListIndex, ".", "Name")] = describeSpotPriceHistoryRequestFilter.Name;
                }
                List<string> filterValueList = describeSpotPriceHistoryRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeSpotPriceHistoryRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeSpotPriceHistoryRequestFilterListIndex++;
            }
            if (request.IsSetAvailabilityZone())
            {
                parameters["AvailabilityZone"] = request.AvailabilityZone;
            }
            if (request.IsSetMaxResults())
            {
                parameters["MaxResults"] = request.MaxResults.ToString();
            }
            if (request.IsSetNextToken())
            {
                parameters["NextToken"] = request.NextToken;
            }

            return parameters;
        }

        /**
         * Convert CreateSpotDatafeedSubscriptionRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateSpotDatafeedSubscription";
            if (request.IsSetBucket())
            {
                parameters["Bucket"] = request.Bucket;
            }
            if (request.IsSetPrefix())
            {
                parameters["Prefix"] = request.Prefix;
            }

            return parameters;
        }

        /**
         * Convert DescribeSpotDatafeedSubscriptionRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeSpotDatafeedSubscription";

            return parameters;
        }

        /**
         * Convert DeleteSpotDatafeedSubscriptionRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteSpotDatafeedSubscription";

            return parameters;
        }

        /**
         * Convert ImportInstanceRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertImportInstance(ImportInstanceRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ImportInstance";
            if (request.IsSetDescription())
            {
                parameters["Description"] = request.Description;
            }
            if (request.IsSetLaunchSpecification())
            {
                ImportInstanceLaunchSpecificationType importInstanceRequestLaunchSpecification = request.LaunchSpecification;
                if (importInstanceRequestLaunchSpecification.IsSetArchitecture())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "Architecture")] = importInstanceRequestLaunchSpecification.Architecture;
                }
                List<string> launchSpecificationSecurityGroupList = request.LaunchSpecification.SecurityGroup;
                int launchSpecificationSecurityGroupListIndex = 1;
                foreach (string launchSpecificationSecurityGroup in launchSpecificationSecurityGroupList)
                {
                    parameters[String.Concat("LaunchSpecification", ".", "GroupName", ".", launchSpecificationSecurityGroupListIndex)] = launchSpecificationSecurityGroup;
                    launchSpecificationSecurityGroupListIndex++;
                }
                List<string> launchSpecificationSecurityGroupIdList = request.LaunchSpecification.SecurityGroupId;
                int launchSpecificationSecurityGroupIdListIndex = 1;
                foreach (string launchSpecificationSecurityGroupId in launchSpecificationSecurityGroupIdList)
                {
                    parameters[String.Concat("LaunchSpecification", ".", "GroupId", ".", launchSpecificationSecurityGroupIdListIndex)] = launchSpecificationSecurityGroupId;
                    launchSpecificationSecurityGroupIdListIndex++;
                }
                if (importInstanceRequestLaunchSpecification.IsSetUserData())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "UserData")] = importInstanceRequestLaunchSpecification.UserData;
                }
                if (importInstanceRequestLaunchSpecification.IsSetInstanceType())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "InstanceType")] = importInstanceRequestLaunchSpecification.InstanceType;
                }
                if (importInstanceRequestLaunchSpecification.IsSetPlacement())
                {
                    Placement launchSpecificationPlacement = importInstanceRequestLaunchSpecification.Placement;
                    if (launchSpecificationPlacement.IsSetAvailabilityZone())
                    {
                        parameters[String.Concat("LaunchSpecification", ".", "Placement", ".", "AvailabilityZone")] = launchSpecificationPlacement.AvailabilityZone;
                    }
                    if (launchSpecificationPlacement.IsSetGroupName())
                    {
                        parameters[String.Concat("LaunchSpecification", ".", "Placement", ".", "GroupName")] = launchSpecificationPlacement.GroupName;
                    }
                }
                if (importInstanceRequestLaunchSpecification.IsSetMonitoring())
                {
                    MonitoringSpecification launchSpecificationMonitoring = importInstanceRequestLaunchSpecification.Monitoring;
                    if (launchSpecificationMonitoring.IsSetEnabled())
                    {
                        parameters[String.Concat("LaunchSpecification", ".", "Monitoring", ".", "Enabled")] = launchSpecificationMonitoring.Enabled.ToString().ToLower();
                    }
                }
                if (importInstanceRequestLaunchSpecification.IsSetSubnetId())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "SubnetId")] = importInstanceRequestLaunchSpecification.SubnetId;
                }
                if (importInstanceRequestLaunchSpecification.IsSetInstanceInitiatedShutdownBehavior())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "InstanceInitiatedShutdownBehavior")] = importInstanceRequestLaunchSpecification.InstanceInitiatedShutdownBehavior;
                }
                if (importInstanceRequestLaunchSpecification.IsSetPrivateIpAddress())
                {
                    parameters[String.Concat("LaunchSpecification", ".", "PrivateIpAddress")] = importInstanceRequestLaunchSpecification.PrivateIpAddress;
                }
            }
            List<DiskImageType> importInstanceRequestDiskImageList = request.DiskImage;
            int importInstanceRequestDiskImageListIndex = 1;
            foreach (DiskImageType importInstanceRequestDiskImage in importInstanceRequestDiskImageList)
            {
                if (importInstanceRequestDiskImage.IsSetImage())
                {
                    DiskImageDetailType diskImageImage = importInstanceRequestDiskImage.Image;
                    if (diskImageImage.IsSetFormat())
                    {
                        parameters[String.Concat("DiskImage", ".", importInstanceRequestDiskImageListIndex, ".", "Image", ".", "Format")] = diskImageImage.Format;
                    }
                    if (diskImageImage.IsSetBytes())
                    {
                        parameters[String.Concat("DiskImage", ".", importInstanceRequestDiskImageListIndex, ".", "Image", ".", "Bytes")] = diskImageImage.Bytes.ToString();
                    }
                    if (diskImageImage.IsSetImportManifestUrl())
                    {
                        parameters[String.Concat("DiskImage", ".", importInstanceRequestDiskImageListIndex, ".", "Image", ".", "ImportManifestUrl")] = diskImageImage.ImportManifestUrl;
                    }
                }
                if (importInstanceRequestDiskImage.IsSetDescription())
                {
                    parameters[String.Concat("DiskImage", ".", importInstanceRequestDiskImageListIndex, ".", "Description")] = importInstanceRequestDiskImage.Description;
                }
                if (importInstanceRequestDiskImage.IsSetVolume())
                {
                    DiskImageVolumeType diskImageVolume = importInstanceRequestDiskImage.Volume;
                    if (diskImageVolume.IsSetSize())
                    {
                        parameters[String.Concat("DiskImage", ".", importInstanceRequestDiskImageListIndex, ".", "Volume", ".", "Size")] = diskImageVolume.Size.ToString();
                    }
                }

                importInstanceRequestDiskImageListIndex++;
            }
            if (request.IsSetPlatform())
            {
                parameters["Platform"] = request.Platform;
            }

            return parameters;
        }

        /**
         * Convert ImportVolumeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertImportVolume(ImportVolumeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ImportVolume";
            if (request.IsSetAvailabilityZone())
            {
                parameters["AvailabilityZone"] = request.AvailabilityZone;
            }
            if (request.IsSetImage())
            {
                DiskImageDetailType importVolumeRequestImage = request.Image;
                if (importVolumeRequestImage.IsSetFormat())
                {
                    parameters[String.Concat("Image", ".", "Format")] = importVolumeRequestImage.Format;
                }
                if (importVolumeRequestImage.IsSetBytes())
                {
                    parameters[String.Concat("Image", ".", "Bytes")] = importVolumeRequestImage.Bytes.ToString();
                }
                if (importVolumeRequestImage.IsSetImportManifestUrl())
                {
                    parameters[String.Concat("Image", ".", "ImportManifestUrl")] = importVolumeRequestImage.ImportManifestUrl;
                }
            }
            if (request.IsSetDescription())
            {
                parameters["Description"] = request.Description;
            }
            if (request.IsSetVolume())
            {
                DiskImageVolumeType importVolumeRequestVolume = request.Volume;
                if (importVolumeRequestVolume.IsSetSize())
                {
                    parameters[String.Concat("Volume", ".", "Size")] = importVolumeRequestVolume.Size.ToString();
                }
            }

            return parameters;
        }

        /**
         * Convert DescribeConversionTasksRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeConversionTasks(DescribeConversionTasksRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeConversionTasks";
            List<string> describeConversionTasksRequestConversionTaskIdList = request.ConversionTaskId;
            int describeConversionTasksRequestConversionTaskIdListIndex = 1;
            foreach (string describeConversionTasksRequestConversionTaskId in describeConversionTasksRequestConversionTaskIdList)
            {
                parameters[String.Concat("ConversionTaskId", ".", describeConversionTasksRequestConversionTaskIdListIndex)] = describeConversionTasksRequestConversionTaskId;
                describeConversionTasksRequestConversionTaskIdListIndex++;
            }

            return parameters;
        }

        /**
         * Convert CancelConversionTaskRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCancelConversionTask(CancelConversionTaskRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CancelConversionTask";
            if (request.IsSetConversionTaskId())
            {
                parameters["ConversionTaskId"] = request.ConversionTaskId;
            }

            return parameters;
        }

        /**
         * Convert AuthorizeSecurityGroupEgressRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AuthorizeSecurityGroupEgress";
            if (request.IsSetGroupId())
            {
                parameters["GroupId"] = request.GroupId;
            }
            List<IpPermissionSpecification> authorizeSecurityGroupEgressRequestIpPermissionsList = request.IpPermissions;
            int authorizeSecurityGroupEgressRequestIpPermissionsListIndex = 1;
            foreach (IpPermissionSpecification authorizeSecurityGroupEgressRequestIpPermissions in authorizeSecurityGroupEgressRequestIpPermissionsList)
            {
                if (authorizeSecurityGroupEgressRequestIpPermissions.IsSetIpProtocol())
                {
                    parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "IpProtocol")] = authorizeSecurityGroupEgressRequestIpPermissions.IpProtocol;
                }
                if (authorizeSecurityGroupEgressRequestIpPermissions.IsSetFromPort())
                {
                    parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "FromPort")] = authorizeSecurityGroupEgressRequestIpPermissions.FromPort.ToString();
                }
                if (authorizeSecurityGroupEgressRequestIpPermissions.IsSetToPort())
                {
                    parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "ToPort")] = authorizeSecurityGroupEgressRequestIpPermissions.ToPort.ToString();
                }
                List<UserIdGroupPair> ipPermissionsGroupsList = authorizeSecurityGroupEgressRequestIpPermissions.Groups;
                int ipPermissionsGroupsListIndex = 1;
                foreach (UserIdGroupPair ipPermissionsGroups in ipPermissionsGroupsList)
                {
                    if (ipPermissionsGroups.IsSetUserId())
                    {
                        parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "Groups", ".", ipPermissionsGroupsListIndex, ".", "UserId")] = ipPermissionsGroups.UserId;
                    }
                    if (ipPermissionsGroups.IsSetGroupId())
                    {
                        parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "Groups", ".", ipPermissionsGroupsListIndex, ".", "GroupId")] = ipPermissionsGroups.GroupId;
                    }
                    if (ipPermissionsGroups.IsSetGroupName())
                    {
                        parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "Groups", ".", ipPermissionsGroupsListIndex, ".", "GroupName")] = ipPermissionsGroups.GroupName;
                    }

                    ipPermissionsGroupsListIndex++;
                }
                List<string> ipPermissionsIpRangesList = authorizeSecurityGroupEgressRequestIpPermissions.IpRanges;
                int ipPermissionsIpRangesListIndex = 1;
                foreach (string ipPermissionsIpRanges in ipPermissionsIpRangesList)
                {
                    parameters[String.Concat("IpPermissions", ".", authorizeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "IpRanges", ".", ipPermissionsIpRangesListIndex, ".CidrIp")] = ipPermissionsIpRanges;
                    ipPermissionsIpRangesListIndex++;
                }

                authorizeSecurityGroupEgressRequestIpPermissionsListIndex++;
            }

            return parameters;
        }

        /**
         * Convert RevokeSecurityGroupEgressRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "RevokeSecurityGroupEgress";
            if (request.IsSetGroupId())
            {
                parameters["GroupId"] = request.GroupId;
            }
            List<IpPermissionSpecification> revokeSecurityGroupEgressRequestIpPermissionsList = request.IpPermissions;
            int revokeSecurityGroupEgressRequestIpPermissionsListIndex = 1;
            foreach (IpPermissionSpecification revokeSecurityGroupEgressRequestIpPermissions in revokeSecurityGroupEgressRequestIpPermissionsList)
            {
                if (revokeSecurityGroupEgressRequestIpPermissions.IsSetIpProtocol())
                {
                    parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "IpProtocol")] = revokeSecurityGroupEgressRequestIpPermissions.IpProtocol;
                }
                if (revokeSecurityGroupEgressRequestIpPermissions.IsSetFromPort())
                {
                    parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "FromPort")] = revokeSecurityGroupEgressRequestIpPermissions.FromPort.ToString();
                }
                if (revokeSecurityGroupEgressRequestIpPermissions.IsSetToPort())
                {
                    parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "ToPort")] = revokeSecurityGroupEgressRequestIpPermissions.ToPort.ToString();
                }
                List<UserIdGroupPair> ipPermissionsGroupsList = revokeSecurityGroupEgressRequestIpPermissions.Groups;
                int ipPermissionsGroupsListIndex = 1;
                foreach (UserIdGroupPair ipPermissionsGroups in ipPermissionsGroupsList)
                {
                    if (ipPermissionsGroups.IsSetUserId())
                    {
                        parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "Groups", ".", ipPermissionsGroupsListIndex, ".", "UserId")] = ipPermissionsGroups.UserId;
                    }
                    if (ipPermissionsGroups.IsSetGroupId())
                    {
                        parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "Groups", ".", ipPermissionsGroupsListIndex, ".", "GroupId")] = ipPermissionsGroups.GroupId;
                    }
                    if (ipPermissionsGroups.IsSetGroupName())
                    {
                        parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "Groups", ".", ipPermissionsGroupsListIndex, ".", "GroupName")] = ipPermissionsGroups.GroupName;
                    }

                    ipPermissionsGroupsListIndex++;
                }
                List<string> ipPermissionsIpRangesList = revokeSecurityGroupEgressRequestIpPermissions.IpRanges;
                int ipPermissionsIpRangesListIndex = 1;
                foreach (string ipPermissionsIpRanges in ipPermissionsIpRangesList)
                {
                    parameters[String.Concat("IpPermissions", ".", revokeSecurityGroupEgressRequestIpPermissionsListIndex, ".", "IpRanges", ".", ipPermissionsIpRangesListIndex, ".CidrIp")] = ipPermissionsIpRanges;
                    ipPermissionsIpRangesListIndex++;
                }

                revokeSecurityGroupEgressRequestIpPermissionsListIndex++;
            }

            return parameters;
        }

        /**
         * Convert CreateInternetGatewayRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateInternetGateway(CreateInternetGatewayRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateInternetGateway";

            return parameters;
        }

        /**
         * Convert DescribeInternetGatewaysRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeInternetGateways(DescribeInternetGatewaysRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeInternetGateways";
            List<string> describeInternetGatewaysRequestInternetGatewayIdList = request.InternetGatewayId;
            int describeInternetGatewaysRequestInternetGatewayIdListIndex = 1;
            foreach (string describeInternetGatewaysRequestInternetGatewayId in describeInternetGatewaysRequestInternetGatewayIdList)
            {
                parameters[String.Concat("InternetGatewayId", ".", describeInternetGatewaysRequestInternetGatewayIdListIndex)] = describeInternetGatewaysRequestInternetGatewayId;
                describeInternetGatewaysRequestInternetGatewayIdListIndex++;
            }
            List<Filter> describeInternetGatewaysRequestFilterList = request.Filter;
            int describeInternetGatewaysRequestFilterListIndex = 1;
            foreach (Filter describeInternetGatewaysRequestFilter in describeInternetGatewaysRequestFilterList)
            {
                if (describeInternetGatewaysRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeInternetGatewaysRequestFilterListIndex, ".", "Name")] = describeInternetGatewaysRequestFilter.Name;
                }
                List<string> filterValueList = describeInternetGatewaysRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeInternetGatewaysRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeInternetGatewaysRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DeleteInternetGatewayRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteInternetGateway(DeleteInternetGatewayRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteInternetGateway";
            if (request.IsSetInternetGatewayId())
            {
                parameters["InternetGatewayId"] = request.InternetGatewayId;
            }

            return parameters;
        }

        /**
         * Convert AttachInternetGatewayRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAttachInternetGateway(AttachInternetGatewayRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AttachInternetGateway";
            if (request.IsSetInternetGatewayId())
            {
                parameters["InternetGatewayId"] = request.InternetGatewayId;
            }
            if (request.IsSetVpcId())
            {
                parameters["VpcId"] = request.VpcId;
            }

            return parameters;
        }

        /**
         * Convert DetachInternetGatewayRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDetachInternetGateway(DetachInternetGatewayRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DetachInternetGateway";
            if (request.IsSetInternetGatewayId())
            {
                parameters["InternetGatewayId"] = request.InternetGatewayId;
            }
            if (request.IsSetVpcId())
            {
                parameters["VpcId"] = request.VpcId;
            }

            return parameters;
        }

        /**
         * Convert CreateRouteTableRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateRouteTable(CreateRouteTableRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateRouteTable";
            if (request.IsSetVpcId())
            {
                parameters["VpcId"] = request.VpcId;
            }

            return parameters;
        }

        /**
         * Convert DescribeRouteTablesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeRouteTables(DescribeRouteTablesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeRouteTables";
            List<string> describeRouteTablesRequestRouteTableIdList = request.RouteTableId;
            int describeRouteTablesRequestRouteTableIdListIndex = 1;
            foreach (string describeRouteTablesRequestRouteTableId in describeRouteTablesRequestRouteTableIdList)
            {
                parameters[String.Concat("RouteTableId", ".", describeRouteTablesRequestRouteTableIdListIndex)] = describeRouteTablesRequestRouteTableId;
                describeRouteTablesRequestRouteTableIdListIndex++;
            }
            List<Filter> describeRouteTablesRequestFilterList = request.Filter;
            int describeRouteTablesRequestFilterListIndex = 1;
            foreach (Filter describeRouteTablesRequestFilter in describeRouteTablesRequestFilterList)
            {
                if (describeRouteTablesRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeRouteTablesRequestFilterListIndex, ".", "Name")] = describeRouteTablesRequestFilter.Name;
                }
                List<string> filterValueList = describeRouteTablesRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeRouteTablesRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeRouteTablesRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DeleteRouteTableRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteRouteTable(DeleteRouteTableRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteRouteTable";
            if (request.IsSetRouteTableId())
            {
                parameters["RouteTableId"] = request.RouteTableId;
            }

            return parameters;
        }

        /**
         * Convert AssociateRouteTableRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAssociateRouteTable(AssociateRouteTableRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AssociateRouteTable";
            if (request.IsSetRouteTableId())
            {
                parameters["RouteTableId"] = request.RouteTableId;
            }
            if (request.IsSetSubnetId())
            {
                parameters["SubnetId"] = request.SubnetId;
            }

            return parameters;
        }

        /**
         * Convert ReplaceRouteTableAssociationRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ReplaceRouteTableAssociation";
            if (request.IsSetAssociationId())
            {
                parameters["AssociationId"] = request.AssociationId;
            }
            if (request.IsSetRouteTableId())
            {
                parameters["RouteTableId"] = request.RouteTableId;
            }

            return parameters;
        }

        /**
         * Convert DisassociateRouteTableRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDisassociateRouteTable(DisassociateRouteTableRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DisassociateRouteTable";
            if (request.IsSetAssociationId())
            {
                parameters["AssociationId"] = request.AssociationId;
            }

            return parameters;
        }

        /**
         * Convert CreateRouteRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateRoute(CreateRouteRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateRoute";
            if (request.IsSetRouteTableId())
            {
                parameters["RouteTableId"] = request.RouteTableId;
            }
            if (request.IsSetDestinationCidrBlock())
            {
                parameters["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (request.IsSetGatewayId())
            {
                parameters["GatewayId"] = request.GatewayId;
            }
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }
            if (request.IsSetNetworkInterfaceId())
            {
                parameters["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }

            return parameters;
        }

        /**
         * Convert ReplaceRouteRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertReplaceRoute(ReplaceRouteRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ReplaceRoute";
            if (request.IsSetRouteTableId())
            {
                parameters["RouteTableId"] = request.RouteTableId;
            }
            if (request.IsSetDestinationCidrBlock())
            {
                parameters["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (request.IsSetGatewayId())
            {
                parameters["GatewayId"] = request.GatewayId;
            }
            if (request.IsSetInstanceId())
            {
                parameters["InstanceId"] = request.InstanceId;
            }
            if (request.IsSetNetworkInterfaceId())
            {
                parameters["NetworkInterfaceid"] = request.NetworkInterfaceId;
            }

            return parameters;
        }

        /**
         * Convert DeleteRouteRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteRoute(DeleteRouteRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteRoute";
            if (request.IsSetRouteTableId())
            {
                parameters["RouteTableId"] = request.RouteTableId;
            }
            if (request.IsSetDestinationCidrBlock())
            {
                parameters["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }

            return parameters;
        }

        /**
         * Convert CreateNetworkAclRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateNetworkAcl(CreateNetworkAclRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateNetworkAcl";
            if (request.IsSetVpcId())
            {
                parameters["VpcId"] = request.VpcId;
            }

            return parameters;
        }

        /**
         * Convert DescribeNetworkAclsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeNetworkAcls(DescribeNetworkAclsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeNetworkAcls";
            List<string> describeNetworkAclsRequestNetworkAclIdList = request.NetworkAclId;
            int describeNetworkAclsRequestNetworkAclIdListIndex = 1;
            foreach (string describeNetworkAclsRequestNetworkAclId in describeNetworkAclsRequestNetworkAclIdList)
            {
                parameters[String.Concat("NetworkAclId", ".", describeNetworkAclsRequestNetworkAclIdListIndex)] = describeNetworkAclsRequestNetworkAclId;
                describeNetworkAclsRequestNetworkAclIdListIndex++;
            }
            List<Filter> describeNetworkAclsRequestFilterList = request.Filter;
            int describeNetworkAclsRequestFilterListIndex = 1;
            foreach (Filter describeNetworkAclsRequestFilter in describeNetworkAclsRequestFilterList)
            {
                if (describeNetworkAclsRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeNetworkAclsRequestFilterListIndex, ".", "Name")] = describeNetworkAclsRequestFilter.Name;
                }
                List<string> filterValueList = describeNetworkAclsRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeNetworkAclsRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeNetworkAclsRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DeleteNetworkAclRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteNetworkAcl(DeleteNetworkAclRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteNetworkAcl";
            if (request.IsSetNetworkAclId())
            {
                parameters["NetworkAclId"] = request.NetworkAclId;
            }

            return parameters;
        }

        /**
         * Convert ReplaceNetworkAclAssociationRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ReplaceNetworkAclAssociation";
            if (request.IsSetAssociationId())
            {
                parameters["AssociationId"] = request.AssociationId;
            }
            if (request.IsSetNetworkAclId())
            {
                parameters["NetworkAclId"] = request.NetworkAclId;
            }

            return parameters;
        }

        /**
         * Convert CreateNetworkAclEntryRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateNetworkAclEntry(CreateNetworkAclEntryRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateNetworkAclEntry";
            if (request.IsSetNetworkAclId())
            {
                parameters["NetworkAclId"] = request.NetworkAclId;
            }
            if (request.IsSetRuleNumber())
            {
                parameters["RuleNumber"] = request.RuleNumber.ToString();
            }
            if (request.IsSetProtocol())
            {
                parameters["Protocol"] = request.Protocol;
            }
            if (request.IsSetRuleAction())
            {
                parameters["RuleAction"] = request.RuleAction;
            }
            if (request.IsSetEgress())
            {
                parameters["Egress"] = request.Egress.ToString().ToLower();
            }
            if (request.IsSetCidrBlock())
            {
                parameters["CidrBlock"] = request.CidrBlock;
            }
            if (request.IsSetIcmp())
            {
                Icmp createNetworkAclEntryRequestIcmp = request.Icmp;
                if (createNetworkAclEntryRequestIcmp.IsSetCode())
                {
                    parameters[String.Concat("Icmp", ".", "Code")] = createNetworkAclEntryRequestIcmp.Code.ToString();
                }
                if (createNetworkAclEntryRequestIcmp.IsSetType())
                {
                    parameters[String.Concat("Icmp", ".", "Type")] = createNetworkAclEntryRequestIcmp.Type.ToString();
                }
            }
            if (request.IsSetPortRange())
            {
                PortRange createNetworkAclEntryRequestPortRange = request.PortRange;
                if (createNetworkAclEntryRequestPortRange.IsSetFrom())
                {
                    parameters[String.Concat("PortRange", ".", "From")] = createNetworkAclEntryRequestPortRange.From.ToString();
                }
                if (createNetworkAclEntryRequestPortRange.IsSetTo())
                {
                    parameters[String.Concat("PortRange", ".", "To")] = createNetworkAclEntryRequestPortRange.To.ToString();
                }
            }

            return parameters;
        }

        /**
         * Convert ReplaceNetworkAclEntryRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ReplaceNetworkAclEntry";
            if (request.IsSetNetworkAclId())
            {
                parameters["NetworkAclId"] = request.NetworkAclId;
            }
            if (request.IsSetRuleNumber())
            {
                parameters["RuleNumber"] = request.RuleNumber.ToString();
            }
            if (request.IsSetProtocol())
            {
                parameters["Protocol"] = request.Protocol;
            }
            if (request.IsSetRuleAction())
            {
                parameters["RuleAction"] = request.RuleAction;
            }
            if (request.IsSetEgress())
            {
                parameters["Egress"] = request.Egress.ToString().ToLower();
            }
            if (request.IsSetCidrBlock())
            {
                parameters["CidrBlock"] = request.CidrBlock;
            }
            if (request.IsSetIcmp())
            {
                Icmp replaceNetworkAclEntryRequestIcmp = request.Icmp;
                if (replaceNetworkAclEntryRequestIcmp.IsSetCode())
                {
                    parameters[String.Concat("Icmp", ".", "Code")] = replaceNetworkAclEntryRequestIcmp.Code.ToString();
                }
                if (replaceNetworkAclEntryRequestIcmp.IsSetType())
                {
                    parameters[String.Concat("Icmp", ".", "Type")] = replaceNetworkAclEntryRequestIcmp.Type.ToString();
                }
            }
            if (request.IsSetPortRange())
            {
                PortRange replaceNetworkAclEntryRequestPortRange = request.PortRange;
                if (replaceNetworkAclEntryRequestPortRange.IsSetFrom())
                {
                    parameters[String.Concat("PortRange", ".", "From")] = replaceNetworkAclEntryRequestPortRange.From.ToString();
                }
                if (replaceNetworkAclEntryRequestPortRange.IsSetTo())
                {
                    parameters[String.Concat("PortRange", ".", "To")] = replaceNetworkAclEntryRequestPortRange.To.ToString();
                }
            }

            return parameters;
        }

        /**
         * Convert DeleteNetworkAclEntryRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteNetworkAclEntry";
            if (request.IsSetNetworkAclId())
            {
                parameters["NetworkAclId"] = request.NetworkAclId;
            }
            if (request.IsSetRuleNumber())
            {
                parameters["RuleNumber"] = request.RuleNumber.ToString();
            }
            if (request.IsSetEgress())
            {
                parameters["Egress"] = request.Egress.ToString().ToLower();
            }

            return parameters;
        }

        /**
         * Convert AttachNetworkInterfaceRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAttachNetworkInterface(AttachNetworkInterfaceRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AttachNetworkInterface";

            if (request.IsSetNetworkInterfaceId())
                parameters["NetworkInterfaceId"] = request.NetworkInterfaceId;
            if (request.IsSetInstanceId())
                parameters["InstanceId"] = request.InstanceId;
            if (request.IsSetDeviceIndex())
                parameters["DeviceIndex"] = request.DeviceIndex.ToString();

            return parameters;
        }

        /**
         * Convert CreateNetworkInterfaceRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateNetworkInterface(CreateNetworkInterfaceRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateNetworkInterface";

            if (request.IsSetSubnetId())
                parameters["SubnetId"] = request.SubnetId;
            if (request.IsSetDescription())
                parameters["Description"] = request.Description;
            if (request.IsSetPrivateIpAddress())
                parameters["PrivateIpAddress"] = request.PrivateIpAddress;

            if (request.IsSetGroupId())
            {
                List<string> securityGroupIdList = request.GroupId;
                int securityGroupIdListListIndex = 1;
                foreach (string securityGroupId in securityGroupIdList)
                {
                    parameters[String.Concat("SecurityGroupId", ".", securityGroupIdListListIndex)] = securityGroupId;
                    securityGroupIdListListIndex++;
                }
            }

            if (request.IsSetPrivateIpAddresses())
            {
                List<PrivateIpAddress> privateIpAddressesList = request.PrivateIpAddresses;
                int privateIpAddressesListIndex = 1;
                foreach (PrivateIpAddress privateIpAddress in privateIpAddressesList)
                {
                    parameters[String.Concat("PrivateIpAddresses", ".", privateIpAddressesListIndex, ".", "Primary")] = privateIpAddress.Primary.ToString().ToLower();
                    parameters[String.Concat("PrivateIpAddresses", ".", privateIpAddressesListIndex, ".", "PrivateIpAddress")] = privateIpAddress.IpAddress;
                    privateIpAddressesListIndex++;
                }
            }

            if (request.IsSetSecondaryPrivateIpAddressCount())
                parameters["SecondaryPrivateIpAddressCount"] = request.SecondaryPrivateIpAddressCount.ToString();

            return parameters;
        }

        /**
         * Convert DeleteNetworkInterfaceRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteNetworkInterface(DeleteNetworkInterfaceRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteNetworkInterface";

            if (request.IsSetNetworkInterfaceId())
                parameters["NetworkInterfaceId"] = request.NetworkInterfaceId;

            return parameters;
        }

        /**
         * Convert DescribeNetworkInterfaceAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeNetworkInterfaceAttribute";

            if (request.IsSetNetworkInterfaceId())
            {
                parameters["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }

            return parameters;
        }

        /**
         * Convert DescribeNetworkInterfacesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeNetworkInterfaces";

            List<string> describeNetworkInterfacesRequestIdList = request.NetworkInterfaceId;
            int describeNetworkInterfacesRequestListIndex = 1;
            foreach (string describeNetworkInterfacesRequestInterfaceId in describeNetworkInterfacesRequestIdList)
            {
                parameters[String.Concat("NetworkInterfaceId", ".", describeNetworkInterfacesRequestListIndex)] = describeNetworkInterfacesRequestInterfaceId;
                describeNetworkInterfacesRequestListIndex++;
            }

            List<Filter> describeNetworkInterfacesRequestFilterList = request.Filter;
            int describeNetworkInterfacesRequestFilterListIndex = 1;
            foreach (Filter describeNetworkInterfacesRequestFilter in describeNetworkInterfacesRequestFilterList)
            {
                if (describeNetworkInterfacesRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeNetworkInterfacesRequestFilterListIndex, ".", "Name")] = describeNetworkInterfacesRequestFilter.Name;
                }
                List<string> filterValueList = describeNetworkInterfacesRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeNetworkInterfacesRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeNetworkInterfacesRequestFilterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DetachNetworkInterfaceRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDetachNetworkInterface(DetachNetworkInterfaceRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DetachNetworkInterface";

            if (request.IsSetAttachmentId())
                parameters["AttachmentId"] = request.AttachmentId;
            if (request.IsSetForce())
                parameters["Force"] = request.Force.ToString();

            return parameters;
        }

        /**
         * Convert ModifyNetworkInterfaceAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ModifyNetworkInterfaceAttribute";

            if (request.IsSetNetworkInterfaceId())
            {
                parameters["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (request.IsSetDescription())
            {
                parameters["Description"] = request.Description;
            }
            if (request.IsSetSourceDestCheck())
            {
                parameters["SourceDestCheck"] = request.SourceDestCheck.ToString();
            }
            if (request.IsSetGroupId())
            {
                List<string> groupIdList = request.GroupId;
                int groupIdListListIndex = 1;
                foreach (string groupId in groupIdList)
                {
                    parameters[String.Concat("SecurityGroupId", ".", groupIdListListIndex)] = groupId;
                    groupIdListListIndex++;
                }
            }
            if (request.IsSetAttachment())
            {
                ModifyNetworkInterfaceAttachment attachment = request.Attachment;
                if (attachment.IsSetAttachmentId())
                {
                    parameters[String.Concat("Attachment", ".", "AttachmentId")] = attachment.AttachmentId;
                }
                if (attachment.IsSetDeleteOnTermination())
                {
                    parameters[String.Concat("Attachment", ".", "DeleteOnTermination")] = attachment.DeleteOnTermination.ToString();
                }
            }

            return parameters;
        }

        /**
         * Convert ResetNetworkInterfaceAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ResetNetworkInterfaceAttribute";

            if (request.IsSetNetworkInterfaceId())
            {
                parameters["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }

            return parameters;
        }

        /**
         * Convert DescribeVolumeStatusRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeVolumeStatus(DescribeVolumeStatusRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeVolumeStatus";

            if (request.IsSetVolumeId())
            {
                List<string> describeVolumeStatusRequestVolumeIdList = request.VolumeId;
                int describeVolumeStatusRequestVolumeIdListIndex = 1;
                foreach (string describeVolumeStatusRequestVolumeId in describeVolumeStatusRequestVolumeIdList)
                {
                    parameters[String.Concat("VolumeId", ".", describeVolumeStatusRequestVolumeIdListIndex)] = describeVolumeStatusRequestVolumeId;
                    describeVolumeStatusRequestVolumeIdListIndex++;
                }
            }

            if (request.IsSetFilter())
            {
                List<Filter> describeInstanceStatusRequestFilterList = request.Filter;
                int describeInstanceStatusRequestFilterListIndex = 1;
                foreach (Filter describeInstanceStatusRequestFilter in describeInstanceStatusRequestFilterList)
                {
                    if (describeInstanceStatusRequestFilter.IsSetName())
                    {
                        parameters[String.Concat("Filter", ".", describeInstanceStatusRequestFilterListIndex, ".", "Name")] = describeInstanceStatusRequestFilter.Name;
                    }
                    List<string> filterValueList = describeInstanceStatusRequestFilter.Value;
                    int filterValueListIndex = 1;
                    foreach (string filterValue in filterValueList)
                    {
                        parameters[String.Concat("Filter", ".", describeInstanceStatusRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                        filterValueListIndex++;
                    }

                    describeInstanceStatusRequestFilterListIndex++;
                }
            }

            if (request.IsSetMaxResults())
            {
                parameters["MaxResults"] = request.MaxResults.ToString();
            }

            if (request.IsSetNextToken())
            {
                parameters["NextToken"] = request.NextToken;
            }

            return parameters;
        }

        /**
         * Convert EnableVolumeIORequest to name value pairs
         */
        private static IDictionary<string, string> ConvertEnableVolumeIO(EnableVolumeIORequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "EnableVolumeIO";

            if (request.IsSetVolumeId())
            {
                parameters["VolumeId"] = request.VolumeId;
            }

            return parameters;
        }

        /**
         * Convert ModifyVolumeAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertModifyVolumeAttribute(ModifyVolumeAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ModifyVolumeAttribute";

            if (request.IsSetVolumeId())
            {
                parameters["VolumeId"] = request.VolumeId;
            }
            if (request.IsSetAutoEnableIO())
            {
                parameters["AutoEnableIO.Value"] = request.AutoEnableIO.ToString().ToLower();
            }

            return parameters;
        }

        /**
         * Convert DescribeVolumeAttributeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeVolumeAttribute(DescribeVolumeAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeVolumeAttribute";

            if (request.IsSetVolumeId())
            {
                parameters["VolumeId"] = request.VolumeId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }

            return parameters;
        }


        /**
         * Convert AssignPrivateIpAddresses to name value pairs
         */
        private static IDictionary<string, string> ConvertAssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AssignPrivateIpAddresses";

            if (request.IsSetNetworkInterfaceId())
            {
                parameters["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (request.IsSetSecondaryPrivateIpAddressCount())
            {
                parameters["SecondaryPrivateIpAddressCount"] = request.SecondaryPrivateIpAddressCount.ToString();
            }
            if (request.IsSetAllowReassignment())
            {
                parameters["AllowReassignment"] = request.AllowReassignment.ToString().ToLower();
            }
            if (request.IsSetPrivateIpAddresses())
            {
                List<string> privateIpAddressList = request.PrivateIpAddresses;
                int privateIpAddressListIndex = 1;
                foreach (string privateIpAddress in privateIpAddressList)
                {
                    parameters[String.Concat("PrivateIpAddress", ".", privateIpAddressListIndex)] = privateIpAddress;
                    privateIpAddressListIndex++;
                }
            }

            return parameters;
        }

        /**
         * Convert UnassignPrivateIpAddresses to name value pairs
         */
        private static IDictionary<string, string> ConvertUnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "UnassignPrivateIpAddresses";

            if (request.IsSetNetworkInterfaceId())
            {
                parameters["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (request.IsSetPrivateIpAddresses())
            {
                List<string> privateIpAddressList = request.PrivateIpAddresses;
                int privateIpAddressListIndex = 1;
                foreach (string privateIpAddress in privateIpAddressList)
                {
                    parameters[String.Concat("PrivateIpAddress", ".", privateIpAddressListIndex)] = privateIpAddress;
                    privateIpAddressListIndex++;
                }
            }

            return parameters;
        }

        /**
         * Convert CreateVpnConnectionRouteRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateVpnConnectionRoute";

            if (request.IsSetVpnConnectionId())
            {
                parameters["VpnConnectionId"] = request.VpnConnectionId;
            }
            if (request.IsSetDestinationCidrBlock())
            {
                parameters["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }

            return parameters;
        }

        /**
         * Convert DeleteVpnConnectionRouteRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteVpnConnectionRoute";

            if (request.IsSetVpnConnectionId())
            {
                parameters["VpnConnectionId"] = request.VpnConnectionId;
            }
            if (request.IsSetDestinationCidrBlock())
            {
                parameters["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }

            return parameters;
        }

        /**
         * Convert EnableVGWRoutePropagationRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertEnableVGWRoutePropagation(EnableVGWRoutePropagationRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "EnableVGWRoutePropagation";

            if (request.IsSetRouteTableId())
            {
                parameters["RouteTableId"] = request.RouteTableId;
            }
            if (request.IsSetGatewayId())
            {
                parameters["GatewayId"] = request.GatewayId;
            }

            return parameters;
        }

        /**
         * Convert DisableVGWRoutePropagationRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDisableVGWRoutePropagation(DisableVGWRoutePropagationRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DisableVGWRoutePropagation";

            if (request.IsSetRouteTableId())
            {
                parameters["RouteTableId"] = request.RouteTableId;
            }
            if (request.IsSetGatewayId())
            {
                parameters["GatewayId"] = request.GatewayId;
            }

            return parameters;
        }


        /**
         * Convert CancelReservedInstancesListingRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCancelReservedInstancesListing(CancelReservedInstancesListingRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CancelReservedInstancesListing";

            if (request.IsSetReservedInstancesListingId())
            {
                parameters["ReservedInstancesListingId"] = request.ReservedInstancesListingId;
            }

            return parameters;
        }

        /**
         * Convert CreateReservedInstancesListingRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateReservedInstancesListing(CreateReservedInstancesListingRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateReservedInstancesListing";

            if (request.IsSetReservedInstancesId())
            {
                parameters["ReservedInstancesId"] = request.ReservedInstancesId;
            }
            if (request.IsSetInstanceCount())
            {
                parameters["InstanceCount"] = request.InstanceCount.ToString();
            }
            if (request.IsSetPricingSchedules())
            {
                List<PricingSchedule> pricingSchedules = request.PricingSchedules;
                int pricingSchedulesListIndex = 1;
                foreach (var pricingSchedule in pricingSchedules)
                {
                    if (pricingSchedule.IsSetTerm())
                    {
                        parameters[String.Concat("PriceSchedules", ".", pricingSchedulesListIndex, "Term")] = pricingSchedule.Term.ToString();
                    }
                    if (pricingSchedule.IsSetPrice())
                    {
                        parameters[String.Concat("PriceSchedules", ".", pricingSchedulesListIndex, "Price")] = pricingSchedule.Price.ToString();
                    }
                    if (pricingSchedule.IsSetCurrencyCode())
                    {
                        parameters[String.Concat("PriceSchedules", ".", pricingSchedulesListIndex, "CurrencyCode")] = pricingSchedule.CurrencyCode;
                    }
                    pricingSchedulesListIndex++;
                }
            }
            if (request.IsSetClientToken())
            {
                parameters["ClientToken"] = request.ClientToken;
            }

            return parameters;
        }

        /**
         * Convert DescribeReservedInstancesListingRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeReservedInstancesListing";

            if (request.IsSetReservedInstancesListingId())
            {
                List<string> ids = request.ReservedInstancesListingId;
                int idsIndex = 1;
                foreach (string id in ids)
                {
                    parameters[string.Concat("ReservedInstancesListingId", idsIndex)] = id;
                    idsIndex++;
                }
            }
            if (request.IsSetReservedInstancesId())
            {
                List<string> ids = request.ReservedInstancesId;
                int idsIndex = 1;
                foreach (string id in ids)
                {
                    parameters[string.Concat("ReservedInstancesId", idsIndex)] = id;
                    idsIndex++;
                }
            }
            List<Filter> filterList = request.Filter;
            int filterListIndex = 1;
            foreach (Filter filter in filterList)
            {
                if (filter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", filterListIndex, ".", "Name")] = filter.Name;
                }
                List<string> filterValueList = filter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", filterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                filterListIndex++;
            }

            return parameters;
        }

        /**
         * Convert CopySnapshotRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCopySnapshot(CopySnapshotRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CopySnapshot";
            if (request.IsSetSourceRegion())
            {
                parameters["SourceRegion"] = request.SourceRegion;
            }
            if (request.IsSetSourceSnapshotId())
            {
                parameters["SourceSnapshotId"] = request.SourceSnapshotId;
            }
            if (request.IsSetDescription())
            {
                parameters["Description"] = request.Description;
            }

            return parameters;
        }

        /**
         * Convert CopySnapshotRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCopyImage(CopyImageRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CopyImage";
            if (request.IsSetSourceRegion())
            {
                parameters["SourceRegion"] = request.SourceRegion;
            }
            if (request.IsSetSourceImageId())
            {
                parameters["SourceImageId"] = request.SourceImageId;
            }
            if (request.IsSetDescription())
            {
                parameters["Description"] = request.Description;
            }
            if (request.IsSetName())
            {
                parameters["Name"] = request.Name;
            }
            if (request.IsSetClientToken())
            {
                parameters["ClientToken"] = request.ClientToken;
            }

            return parameters;
        }

        /**
         * Convert DescribeVpcAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeVpcAttribute(DescribeVpcAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeVpcAttribute";
            if (request.IsSetVpcId())
            {
                parameters["VpcId"] = request.VpcId;
            }
            if (request.IsSetAttribute())
            {
                parameters["Attribute"] = request.Attribute;
            }
            return parameters;
        }

        /**
         * Convert ModifyVpcAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertModifyVpcAttribute(ModifyVpcAttributeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ModifyVpcAttribute";
            if (request.IsSetVpcId())
            {
                parameters["VpcId"] = request.VpcId;
            }
            if (request.IsSetEnableDnsSupport())
            {
                parameters["EnableDnsSupport.Value"] = request.EnableDnsSupport.ToString().ToLower();
            }
            if (request.EnableDnsHostnames)
            {
                parameters["EnableDnsHostnames.Value"] = request.EnableDnsHostnames.ToString().ToLower();
            }

            return parameters;
        }

        /**
         * Convert DescribeAccountAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeAccountAttributes";
            if (request.IsSetAccountAttributeNames())
            {
                List<AccountAttributeName> attributeNames = request.AccountAttributeNames;
                int attributeNamesIndex = 1;
                foreach (AccountAttributeName attributeName in attributeNames)
                {
                    if (attributeName != null)
                    {
                        parameters[String.Concat("AttributeName", ".", attributeNamesIndex)] = attributeName.AttributeName;
                        attributeNamesIndex++;
                    }
                }
            }

            List<Filter> describeAccountAttributesRequestFilterList = request.Filter;
            int describeAccountAttributesRequestFilterListIndex = 1;
            foreach (Filter describeccountAttributesRequestFilter in describeAccountAttributesRequestFilterList)
            {
                if (describeccountAttributesRequestFilter.IsSetName())
                {
                    parameters[String.Concat("Filter", ".", describeAccountAttributesRequestFilterListIndex, ".", "Name")] = describeccountAttributesRequestFilter.Name;
                }
                List<string> filterValueList = describeccountAttributesRequestFilter.Value;
                int filterValueListIndex = 1;
                foreach (string filterValue in filterValueList)
                {
                    parameters[String.Concat("Filter", ".", describeAccountAttributesRequestFilterListIndex, ".", "Value", ".", filterValueListIndex)] = filterValue;
                    filterValueListIndex++;
                }

                describeAccountAttributesRequestFilterListIndex++;
            }

            return parameters;
        }


        /*
         *  Transforms response based on xslt template
         */
        private string Transform(string responseBody, string action, Type t)
        {
            XslCompiledTransform transformer = GetTransform(action, config.ServiceVersion);

            StringReader sr = new StringReader(responseBody);
            using (XmlTextReader xmlR = new XmlTextReader(sr))
            {
                StringBuilder sb = new StringBuilder(1024);
                using (StringWriter sw = new StringWriter(sb))
                {
                    transformer.Transform(xmlR, null, sw);
                    return sb.ToString();
                }
            }
        }

        /*
         *  Retrieves XSLT resource for specific action
         */
        private static Stream GetXsltStream(string action)
        {
            string currentNamespace = typeof(AmazonEC2Client).Namespace;

            // Build the name of the xslt transform to apply to the response
            Assembly assembly = Assembly.GetAssembly(typeof(AmazonEC2Client));
            string assemblyName = assembly.FullName;
            string currentAssemblyName = assemblyName.Split(new char[] { ',' })[0];

            string resourceName = String.Concat(
                currentAssemblyName,
                ".",
                currentNamespace,
                ".Model.",
                action,
                "Response.xslt"
                );

            Assembly currentAssembly = Assembly.GetAssembly(typeof(AmazonEC2Client));
            Stream resourceStream = currentAssembly.GetManifestResourceStream(resourceName);
            if (resourceStream == null)
                throw new InvalidOperationException("Unable to find resource " + resourceName);

            return resourceStream;
        }

        /*
         *  Retrieves XSLT XmlReader for specific action
         */
        private static XmlTextReader GetXsltReader(string action, string serviceVersion)
        {
            string xslt;
            Stream xsltStream = GetXsltStream(action);
            using (StreamReader reader = new StreamReader(xsltStream))
            {
                xslt = reader.ReadToEnd();
            }
            xslt = SetTransformNamespace(xslt, serviceVersion);

            StringReader stringReader = new StringReader(xslt);
            XmlTextReader xmlReader = new XmlTextReader(stringReader);
            return xmlReader;
        }

        /*
         *  Sets the ec2 namespace in the transform to the namespace matching the service version
         */
        private static string SetTransformNamespace(string xslt, string serviceVersion)
        {
            string ns = string.Concat("http://ec2.amazonaws.com/doc/", serviceVersion, "/");
            string defaultNS = "default-ec2-namespace";
            int defaultNSLocation = xslt.IndexOf(defaultNS, StringComparison.Ordinal);
            if (defaultNSLocation < 0)
            {
                throw new AmazonEC2Exception("Invalid XSLT");
            }
            StringBuilder builder = new StringBuilder(xslt);
            builder.Remove(defaultNSLocation, defaultNS.Length);
            builder.Insert(defaultNSLocation, ns);
            xslt = builder.ToString();
            return xslt;
        }

        /*
         *  Retrieves XslCompiledTransform for specific action and service version
         */
        private static XslCompiledTransform GetTransform(string action, string serviceVersion)
        {
            string key = string.Concat(action, "#", serviceVersion);
            XslCompiledTransform transform;
            lock (xsltCacheLock)
            {
                if (!xsltCache.TryGetValue(key, out transform))
                {
                    transform = new XslCompiledTransform();
                    using (XmlTextReader xmlReader = GetXsltReader(action, serviceVersion))
                    {
                        transform.Load(xmlReader);
                    }
                    xsltCache[key] = transform;
                }
            }

            return transform;
        }

        /*
         *  XslCompiledTransform cache, keyed on "[Action]#[ServiceVersion]"
         */
        private static object xsltCacheLock = new object();
        private static Dictionary<string, XslCompiledTransform> xsltCache = new Dictionary<string, XslCompiledTransform>();

        #endregion
    }
}
