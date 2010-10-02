/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2010-06-15
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
        private string awsAccessKeyId;
        private SecureString awsSecretAccessKey;
        private AmazonEC2Config config;
        private bool disposed;
        private string clearAwsSecretAccessKey;

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
                if (fDisposing)
                {
                    //Remove Unmanaged Resources
                    // I.O.W. remove resources that have to be explicitly
                    // "Dispose"d or Closed
                    if (awsSecretAccessKey != null)
                    {
                        awsSecretAccessKey.Dispose();
                        awsSecretAccessKey = null;
                    }
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

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEC2Config())
        {
        }

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
        {
            if (!String.IsNullOrEmpty(awsSecretAccessKey))
            {
                if (config.UseSecureStringForAwsSecretKey)
                {
                    this.awsSecretAccessKey = new SecureString();
                    foreach (char ch in awsSecretAccessKey.ToCharArray())
                    {
                        this.awsSecretAccessKey.AppendChar(ch);
                    }
                    this.awsSecretAccessKey.MakeReadOnly();
                }
                else
                {
                    clearAwsSecretAccessKey = awsSecretAccessKey;
                }
            }
            this.awsAccessKeyId = awsAccessKeyId;
            this.config = config;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.UseNagleAlgorithm = false;
        }

        /// <summary>
        /// Constructs an AmazonEC2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEC2 Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The AmazonEC2 Configuration Object</param>
        public AmazonEC2Client(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonEC2Config config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.config = config;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.UseNagleAlgorithm = false;
        }

        #region Public API

        /// <summary>
        /// Activate License 
        /// </summary>
        /// <param name="request">Activate License  request</param>
        /// <returns>Activate License  Response from the service</returns>
        /// <remarks>
        /// Activates a specific number of licenses for a 90-day period.
        /// Activations can be done against a specific license ID.
        /// </remarks>
        public ActivateLicenseResponse ActivateLicense(ActivateLicenseRequest request)
        {
            return Invoke<ActivateLicenseResponse>(ConvertActivateLicense(request));
        }

        /// <summary>
        /// Allocate Address 
        /// </summary>
        /// <param name="request">Allocate Address  request</param>
        /// <returns>Allocate Address  Response from the service</returns>
        /// <remarks>
        /// The AllocateAddress operation acquires an elastic
        /// IP address for use with your account.
        /// </remarks>
        public AllocateAddressResponse AllocateAddress(AllocateAddressRequest request)
        {
            return Invoke<AllocateAddressResponse>(ConvertAllocateAddress(request));
        }

        /// <summary>
        /// Associate Address 
        /// </summary>
        /// <param name="request">Associate Address  request</param>
        /// <returns>Associate Address  Response from the service</returns>
        /// <remarks>
        /// The AssociateAddress operation associates an
        /// elastic IP address with an instance.
        /// If the IP address is currently
        /// assigned to another instance, the IP
        /// address is assigned to the new
        /// instance. This is an idempotent operation. If you enter
        /// it more than once, Amazon EC2 does not return an error.
        /// </remarks>
        public AssociateAddressResponse AssociateAddress(AssociateAddressRequest request)
        {
            return Invoke<AssociateAddressResponse>(ConvertAssociateAddress(request));
        }

        /// <summary>
        /// Attach Volume 
        /// </summary>
        /// <param name="request">Attach Volume  request</param>
        /// <returns>Attach Volume  Response from the service</returns>
        /// <remarks>
        /// Attach a previously created volume to a running
        /// instance.
        /// </remarks>
        public AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
        {
            return Invoke<AttachVolumeResponse>(ConvertAttachVolume(request));
        }

        /// <summary>
        /// Authorize Security Group Ingress 
        /// </summary>
        /// <param name="request">Authorize Security Group Ingress  request</param>
        /// <returns>Authorize Security Group Ingress  Response from the service</returns>
        /// <remarks>
        /// The AuthorizeSecurityGroupIngress operation adds
        /// permissions to a security group.
        /// Permissions are specified by the IP
        /// protocol (TCP, UDP or ICMP), the source of
        /// the request (by IP range
        /// or an Amazon EC2 user-group pair), the
        /// source and destination port ranges (for TCP and UDP),
        /// and the ICMP codes and types (for ICMP).
        /// When authorizing ICMP, -1 can be used as a wildcard in the
        /// type and code fields.
        /// Permission changes are propagated to instances within the
        /// security group as quickly as possible. However, depending on the
        /// number of instances, a small
        /// delay might occur.
        /// When authorizing a user/group pair permission, GroupName,
        /// SourceSecurityGroupName and
        /// SourceSecurityGroupOwnerId must be
        /// specified. When authorizing a CIDR
        /// IP permission, GroupName, IpProtocol, FromPort, ToPort and
        /// CidrIp must be specified. Mixing these two types of parameters is
        /// not allowed.
        /// </remarks>
        public AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request)
        {
            return Invoke<AuthorizeSecurityGroupIngressResponse>(ConvertAuthorizeSecurityGroupIngress(request));
        }

        /// <summary>
        /// Bundle Instance 
        /// </summary>
        /// <param name="request">Bundle Instance  request</param>
        /// <returns>Bundle Instance  Response from the service</returns>
        /// <remarks>
        /// The BundleInstance operation request that an
        /// instance is bundled the next time it boots.
        /// The bundling process creates a new image from a running instance and
        /// stores the AMI data in S3. Once bundled, the image must be registered in the
        /// normal way using the RegisterImage API.
        /// </remarks>
        public BundleInstanceResponse BundleInstance(BundleInstanceRequest request)
        {
            S3Storage s3 = request.Storage.S3;
            // Check to see if S3 upload policy was set on request.
            // If not, generate. Set expiration to 24 hours.
            if (!s3.IsSetUploadPolicy())
            {
                s3.AWSAccessKeyId = this.awsAccessKeyId;
                S3UploadPolicy policy;
                if (config.UseSecureStringForAwsSecretKey)
                {
                    policy = new S3UploadPolicy(
                        this.awsAccessKeyId,
                        this.awsSecretAccessKey,
                        s3.Bucket,
                        s3.Prefix,
                        1440
                        );
                }
                else
                {
                    policy = new S3UploadPolicy(
                        this.clearAwsSecretAccessKey,
                        s3.Bucket,
                        s3.Prefix,
                        1440
                        );
                }

                s3.UploadPolicy = policy.PolicyString;
                s3.UploadPolicySignature = policy.PolicySignature;
            }
            return Invoke<BundleInstanceResponse>(ConvertBundleInstance(request));
        }

        /// <summary>
        /// Cancel Bundle Task 
        /// </summary>
        /// <param name="request">Cancel Bundle Task  request</param>
        /// <returns>Cancel Bundle Task  Response from the service</returns>
        /// <remarks>
        /// CancelBundleTask operation cancels a pending or
        /// in-progress bundling task. This is an asynchronous
        /// call and it make
        /// take a while for the task to be cancelled.
        /// If a task is cancelled
        /// while it is storing items,
        /// there may be parts of the incomplete AMI
        /// stored in S3.
        /// It is up to the caller to clean up these parts from S3.
        /// </remarks>
        public CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request)
        {
            return Invoke<CancelBundleTaskResponse>(ConvertCancelBundleTask(request));
        }

        /// <summary>
        /// Confirm Product Instance 
        /// </summary>
        /// <param name="request">Confirm Product Instance  request</param>
        /// <returns>Confirm Product Instance  Response from the service</returns>
        /// <remarks>
        /// The ConfirmProductInstance operation returns true
        /// if the specified product code
        /// is attached to the specified instance.
        /// The operation returns false if the
        /// product code is not attached to the
        /// instance.
        /// The ConfirmProductInstance operation can only be executed
        /// by the owner of the
        /// AMI. This feature is useful when an AMI owner is
        /// providing support and wants to
        /// verify whether a user's instance is eligible.
        /// </remarks>
        public ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request)
        {
            return Invoke<ConfirmProductInstanceResponse>(ConvertConfirmProductInstance(request));
        }

        /// <summary>
        /// Create Image 
        /// </summary>
        /// <param name="request">Create Image  request</param>
        /// <returns>Create Image  Response from the service</returns>
        /// <remarks>
        /// Creates an AMI that uses an Amazon EBS root
        /// device from a "running" or "stopped" instance.
        /// AMIs that use an Amazon EBS root device boot
        /// faster than AMIs that use instance stores. They
        /// can be up to 1 TiB in size, use storage that
        /// persists on instance failure, and can be stopped and started.
        /// </remarks>
        public CreateImageResponse CreateImage(CreateImageRequest request)
        {
            return Invoke<CreateImageResponse>(ConvertCreateImage(request));
        }

        /// <summary>
        /// Create Key Pair 
        /// </summary>
        /// <param name="request">Create Key Pair  request</param>
        /// <returns>Create Key Pair  Response from the service</returns>
        /// <remarks>
        /// The CreateKeyPair operation creates a new 2048
        /// bit RSA key pair and returns a
        /// unique ID that can be used to reference
        /// this key pair when launching new
        /// instances. For more information, see
        /// RunInstances.
        /// </remarks>
        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            return Invoke<CreateKeyPairResponse>(ConvertCreateKeyPair(request));
        }

        /// <summary>
        /// Create Placement Group 
        /// </summary>
        /// <param name="request">Create Placement Group  request</param>
        /// <returns>Create Placement Group  Response from the service</returns>
        /// <remarks>
        /// The CreateKeyPair operation creates a new 2048
        /// bit RSA key pair and returns a
        /// unique ID that can be used to reference
        /// this key pair when launching new
        /// instances. For more information, see
        /// RunInstances.
        /// </remarks>
        public CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request)
        {
            return Invoke<CreatePlacementGroupResponse>(ConvertCreatePlacementGroup(request));
        }

        /// <summary>
        /// Create Security Group 
        /// </summary>
        /// <param name="request">Create Security Group  request</param>
        /// <returns>Create Security Group  Response from the service</returns>
        /// <remarks>
        /// The CreateSecurityGroup operation creates a new
        /// security group.
        /// Every instance is launched in a security group. If no security group is
        /// specified during launch, the instances are launched in the default
        /// security group. Instances within the same security
        /// group have unrestricted network access to each other. Instances will
        /// reject network access attempts from other instances in a different
        /// security group. As the owner of instances you can grant or revoke
        /// specific permissions using the AuthorizeSecurityGroupIngress
        /// and RevokeSecurityGroupIngress operations.
        /// </remarks>
        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            return Invoke<CreateSecurityGroupResponse>(ConvertCreateSecurityGroup(request));
        }

        /// <summary>
        /// Create Snapshot 
        /// </summary>
        /// <param name="request">Create Snapshot  request</param>
        /// <returns>Create Snapshot  Response from the service</returns>
        /// <remarks>
        /// Create a snapshot of the volume identified by
        /// volume ID. A volume does not have to be detached
        /// at the time the snapshot is taken.
        /// Important Note:
        /// Snapshot creation requires that the
        /// system is in a consistent state.
        /// For instance, this means that if
        /// taking a snapshot of a database, the
        /// tables must be read-only locked
        /// to ensure that the snapshot will not contain a
        /// corrupted version of the database. Therefore,
        /// be careful when using this API to ensure that
        /// the system remains in the consistent state until the create
        /// snapshot status has returned.
        /// </remarks>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            return Invoke<CreateSnapshotResponse>(ConvertCreateSnapshot(request));
        }

        /// <summary>
        /// Create Volume 
        /// </summary>
        /// <param name="request">Create Volume  request</param>
        /// <returns>Create Volume  Response from the service</returns>
        /// <remarks>
        /// Initializes an empty volume of a given size
        /// </remarks>
        public CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
        {
            return Invoke<CreateVolumeResponse>(ConvertCreateVolume(request));
        }

        /// <summary>
        /// Deactivate License 
        /// </summary>
        /// <param name="request">Deactivate License  request</param>
        /// <returns>Deactivate License  Response from the service</returns>
        /// <remarks>
        /// Deactivates a specific number of licenses.
        /// Deactivations can be done against a specific license ID
        /// after they have persisted for at least a 90-day period.
        /// </remarks>
        public DeactivateLicenseResponse DeactivateLicense(DeactivateLicenseRequest request)
        {
            return Invoke<DeactivateLicenseResponse>(ConvertDeactivateLicense(request));
        }

        /// <summary>
        /// Delete Key Pair 
        /// </summary>
        /// <param name="request">Delete Key Pair  request</param>
        /// <returns>Delete Key Pair  Response from the service</returns>
        /// <remarks>
        /// The DeleteKeyPair operation deletes a key pair.
        /// </remarks>
        public DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            return Invoke<DeleteKeyPairResponse>(ConvertDeleteKeyPair(request));
        }

        /// <summary>
        /// Delete Placement Group 
        /// </summary>
        /// <param name="request">Delete Placement Group  request</param>
        /// <returns>Delete Placement Group  Response from the service</returns>
        /// <remarks>
        /// The DeletePlacementGroup operation deletes a placement group.
        /// </remarks>
        public DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request)
        {
            return Invoke<DeletePlacementGroupResponse>(ConvertDeletePlacementGroup(request));
        }

        /// <summary>
        /// Delete Security Group 
        /// </summary>
        /// <param name="request">Delete Security Group  request</param>
        /// <returns>Delete Security Group  Response from the service</returns>
        /// <remarks>
        /// The DeleteSecurityGroup operation deletes a
        /// security group.
        /// Note:
        /// If you attempt to delete a security group that
        /// contains instances, a fault is returned.
        /// If you attempt to delete a
        /// security group that is referenced by
        /// another security group, a fault
        /// is returned. For example, if security group B has a
        /// rule that allows access from security group A, security group A
        /// cannot be deleted until the allow rule is removed.
        /// </remarks>
        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            return Invoke<DeleteSecurityGroupResponse>(ConvertDeleteSecurityGroup(request));
        }

        /// <summary>
        /// Delete Snapshot 
        /// </summary>
        /// <param name="request">Delete Snapshot  request</param>
        /// <returns>Delete Snapshot  Response from the service</returns>
        /// <remarks>
        /// Deletes the snapshot identitied by snapshotId.
        /// </remarks>
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            return Invoke<DeleteSnapshotResponse>(ConvertDeleteSnapshot(request));
        }

        /// <summary>
        /// Delete Volume 
        /// </summary>
        /// <param name="request">Delete Volume  request</param>
        /// <returns>Delete Volume  Response from the service</returns>
        /// <remarks>
        /// Deletes a previously created volume. Once
        /// successfully deleted, a new
        /// volume can be created with the same name.
        /// </remarks>
        public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            return Invoke<DeleteVolumeResponse>(ConvertDeleteVolume(request));
        }

        /// <summary>
        /// Deregister Image 
        /// </summary>
        /// <param name="request">Deregister Image  request</param>
        /// <returns>Deregister Image  Response from the service</returns>
        /// <remarks>
        /// The DeregisterImage operation deregisters an AMI.
        /// Once deregistered, instances
        /// of the AMI can no longer be launched.
        /// </remarks>
        public DeregisterImageResponse DeregisterImage(DeregisterImageRequest request)
        {
            return Invoke<DeregisterImageResponse>(ConvertDeregisterImage(request));
        }

        /// <summary>
        /// Describe Addresses 
        /// </summary>
        /// <param name="request">Describe Addresses  request</param>
        /// <returns>Describe Addresses  Response from the service</returns>
        /// <remarks>
        /// The DescribeAddresses operation lists elastic IP
        /// addresses assigned to your account.
        /// </remarks>
        public DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
        {
            return Invoke<DescribeAddressesResponse>(ConvertDescribeAddresses(request));
        }

        /// <summary>
        /// Describe Availability Zones 
        /// </summary>
        /// <param name="request">Describe Availability Zones  request</param>
        /// <returns>Describe Availability Zones  Response from the service</returns>
        /// <remarks>
        /// The DescribeAvailabilityZones operation describes
        /// availability zones that are
        /// currently available to the account and
        /// their states.
        /// Availability zones are not the same across accounts.
        /// The availability zone
        /// us-east-1a for account A is not necessarily the
        /// same as us-east-1a for account
        /// B. Zone assignments are mapped
        /// independently for each account.
        /// </remarks>
        public DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
        {
            return Invoke<DescribeAvailabilityZonesResponse>(ConvertDescribeAvailabilityZones(request));
        }

        /// <summary>
        /// Describe Bundle Tasks 
        /// </summary>
        /// <param name="request">Describe Bundle Tasks  request</param>
        /// <returns>Describe Bundle Tasks  Response from the service</returns>
        /// <remarks>
        /// The DescribeBundleTasks operation describes in-progress
        /// and recent bundle tasks. Complete and failed tasks are
        /// removed from the list a short time after completion.
        /// If no bundle ids are given, all bundle tasks are returned.
        /// </remarks>
        public DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request)
        {
            return Invoke<DescribeBundleTasksResponse>(ConvertDescribeBundleTasks(request));
        }

        /// <summary>
        /// Describe Licenses 
        /// </summary>
        /// <param name="request">Describe Licenses  request</param>
        /// <returns>Describe Licenses  Response from the service</returns>
        /// <remarks>
        /// Provides details of a user's registered licenses. Zero or more IDs
        /// may be specified on the call. When one or more license IDs are
        /// specified, only data for the specified IDs are returned.
        /// </remarks>
        public DescribeLicensesResponse DescribeLicenses(DescribeLicensesRequest request)
        {
            return Invoke<DescribeLicensesResponse>(ConvertDescribeLicenses(request));
        }

        /// <summary>
        /// Describe Placement Groups 
        /// </summary>
        /// <param name="request">Describe Placement Groups  request</param>
        /// <returns>Describe Placement Groups  Response from the service</returns>
        /// <remarks>
        /// Returns information about one or more PlacementGroup instances in a
        /// user's account.
        /// </remarks>
        public DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request)
        {
            return Invoke<DescribePlacementGroupsResponse>(ConvertDescribePlacementGroups(request));
        }

        /// <summary>
        /// Describe Snapshot Attribute 
        /// </summary>
        /// <param name="request">Describe Snapshot Attribute  request</param>
        /// <returns>Describe Snapshot Attribute  Response from the service</returns>
        /// <remarks>
        /// Returns information about an attribute of a snapshot.
        /// Only one attribute can be specified per call.
        /// </remarks>
        public DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request)
        {
            return Invoke<DescribeSnapshotAttributeResponse>(ConvertDescribeSnapshotAttribute(request));
        }

        /// <summary>
        /// Describe Image Attribute 
        /// </summary>
        /// <param name="request">Describe Image Attribute  request</param>
        /// <returns>Describe Image Attribute  Response from the service</returns>
        /// <remarks>
        /// The DescribeImageAttribute operation returns
        /// information about an attribute of
        /// an AMI. Only one attribute can be
        /// specified per call.
        /// </remarks>
        public DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request)
        {
            return Invoke<DescribeImageAttributeResponse>(ConvertDescribeImageAttribute(request));
        }

        /// <summary>
        /// Describe Images 
        /// </summary>
        /// <param name="request">Describe Images  request</param>
        /// <returns>Describe Images  Response from the service</returns>
        /// <remarks>
        /// The DescribeImages operation returns information
        /// about AMIs, AKIs, and ARIs
        /// available to the user. Information returned
        /// includes image type, product codes,
        /// architecture, and kernel and RAM
        /// disk IDs. Images available to the user include
        /// public images
        /// available for any user to launch, private images owned
        /// by the user making the request, and private images
        /// owned by other users for which the
        /// user has explicit launch permissions.
        /// Launch permissions fall into three categories:
        /// Public:
        /// The owner of the AMI granted launch permissions for the AMI to the all
        /// group. All users have launch permissions for these AMIs.
        /// Explicit:
        /// The owner of the AMI granted launch permissions to a specific user.
        /// Implicit:
        /// A user has implicit launch permissions for all AMIs he or she owns.
        /// The list of AMIs returned can be modified by specifying AMI IDs, AMI
        /// owners, or users with launch permissions. If no options are specified,
        /// Amazon EC2 returns all AMIs for which the user has launch permissions.
        /// If you specify one or more AMI IDs, only AMIs that have the specified
        /// IDs are returned. If you specify an invalid AMI ID, a fault is returned.
        /// If you specify an AMI ID for which you do not have access, it will not
        /// be included in the returned results.
        /// If you specify one or more AMI
        /// owners, only AMIs from the specified
        /// owners and for which you have
        /// access are returned. The results can include the
        /// account IDs of the specified owners, amazon for
        /// AMIs owned by Amazon or self for AMIs that you own.
        /// If you specify a list of executable users, only users
        /// that have launch
        /// permissions for the AMIs are returned. You can
        /// specify account IDs
        /// (if you own
        /// the AMI(s)), self for AMIs for which
        /// you own or have explicit
        /// permissions, or
        /// all for public AMIs.
        /// Note:
        /// Deregistered images are included in the returned results for an
        /// unspecified
        /// interval after deregistration.
        /// </remarks>
        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            return Invoke<DescribeImagesResponse>(ConvertDescribeImages(request));
        }

        /// <summary>
        /// Describe Instances 
        /// </summary>
        /// <param name="request">Describe Instances  request</param>
        /// <returns>Describe Instances  Response from the service</returns>
        /// <remarks>
        /// The DescribeInstances operation returns
        /// information about instances that you own.
        /// If you specify one or more instance IDs, Amazon EC2 returns
        /// information for those instances. If you do not specify
        /// instance IDs, Amazon EC2 returns information for
        /// all relevant instances. If you specify an invalid
        /// instance ID, a fault is returned. If you specify an instance
        /// that you do not own, it will
        /// not be included in the returned results.
        /// Recently terminated instances might appear in the
        /// returned results. This interval is usually less than one hour.
        /// </remarks>
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            return Invoke<DescribeInstancesResponse>(ConvertDescribeInstances(request));
        }

        /// <summary>
        /// Describe Regions 
        /// </summary>
        /// <param name="request">Describe Regions  request</param>
        /// <returns>Describe Regions  Response from the service</returns>
        /// <remarks>
        /// The DescribeRegions operation describes regions
        /// zones that are
        /// currently available to the account.
        /// </remarks>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            return Invoke<DescribeRegionsResponse>(ConvertDescribeRegions(request));
        }

        /// <summary>
        /// Describe Reserved Instances 
        /// </summary>
        /// <param name="request">Describe Reserved Instances  request</param>
        /// <returns>Describe Reserved Instances  Response from the service</returns>
        /// <remarks>
        /// The DescribeReservedInstances operation describes
        /// Reserved Instances
        /// that were purchased for use with your account.
        /// </remarks>
        public DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            return Invoke<DescribeReservedInstancesResponse>(ConvertDescribeReservedInstances(request));
        }

        /// <summary>
        /// Describe Reserved Instances Offerings 
        /// </summary>
        /// <param name="request">Describe Reserved Instances Offerings  request</param>
        /// <returns>Describe Reserved Instances Offerings  Response from the service</returns>
        /// <remarks>
        /// The DescribeReservedInstancesOfferings operation
        /// describes Reserved
        /// Instance offerings that are available for
        /// purchase. With Amazon EC2
        /// Reserved Instances, you purchase the right
        /// to launch Amazon EC2 instances
        /// for a period of time (without getting
        /// insufficient capacity errors) and
        /// pay a lower usage rate for the
        /// actual time used.
        /// </remarks>
        public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request)
        {
            return Invoke<DescribeReservedInstancesOfferingsResponse>(ConvertDescribeReservedInstancesOfferings(request));
        }

        /// <summary>
        /// Describe Key Pairs 
        /// </summary>
        /// <param name="request">Describe Key Pairs  request</param>
        /// <returns>Describe Key Pairs  Response from the service</returns>
        /// <remarks>
        /// The DescribeKeyPairs operation returns information about key pairs
        /// available to you. If you specify key pairs, information about
        /// those key pairs is returned. Otherwise,
        /// information for all registered key pairs is returned.
        /// </remarks>
        public DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            return Invoke<DescribeKeyPairsResponse>(ConvertDescribeKeyPairs(request));
        }

        /// <summary>
        /// Describe Security Groups 
        /// </summary>
        /// <param name="request">Describe Security Groups  request</param>
        /// <returns>Describe Security Groups  Response from the service</returns>
        /// <remarks>
        /// The DescribeSecurityGroups operation returns
        /// information about security groups
        /// that you own.
        /// If you specify security group names, information about those security
        /// group is returned. Otherwise, information for all security group is
        /// returned. If you specify a group that does not exist, a fault is returned.
        /// </remarks>
        public DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            return Invoke<DescribeSecurityGroupsResponse>(ConvertDescribeSecurityGroups(request));
        }

        /// <summary>
        /// Describe Snapshots 
        /// </summary>
        /// <param name="request">Describe Snapshots  request</param>
        /// <returns>Describe Snapshots  Response from the service</returns>
        /// <remarks>
        /// Describes the indicated snapshots, or in lieu of
        /// that, all snapshots owned by the caller.
        /// </remarks>
        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            return Invoke<DescribeSnapshotsResponse>(ConvertDescribeSnapshots(request));
        }

        /// <summary>
        /// Describe Volumes 
        /// </summary>
        /// <param name="request">Describe Volumes  request</param>
        /// <returns>Describe Volumes  Response from the service</returns>
        /// <remarks>
        /// Describes the status of the indicated or, in lieu
        /// of any specified, all
        /// volumes belonging to the caller.
        /// Volumes that
        /// have been deleted are not described.
        /// </remarks>
        public DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            return Invoke<DescribeVolumesResponse>(ConvertDescribeVolumes(request));
        }

        /// <summary>
        /// Detach Volume 
        /// </summary>
        /// <param name="request">Detach Volume  request</param>
        /// <returns>Detach Volume  Response from the service</returns>
        /// <remarks>
        /// Detach a previously attached volume from a
        /// running instance.
        /// </remarks>
        public DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
        {
            return Invoke<DetachVolumeResponse>(ConvertDetachVolume(request));
        }

        /// <summary>
        /// Disassociate Address 
        /// </summary>
        /// <param name="request">Disassociate Address  request</param>
        /// <returns>Disassociate Address  Response from the service</returns>
        /// <remarks>
        /// The DisassociateAddress operation disassociates
        /// the specified elastic IP
        /// address from the instance to which it is
        /// assigned. This is an idempotent
        /// operation. If you enter it more than
        /// once, Amazon EC2 does not
        /// return an error.
        /// </remarks>
        public DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request)
        {
            return Invoke<DisassociateAddressResponse>(ConvertDisassociateAddress(request));
        }

        /// <summary>
        /// Get Password Data 
        /// </summary>
        /// <param name="request">Get Password Data  request</param>
        /// <returns>Get Password Data  Response from the service</returns>
        /// <remarks>
        /// Retrieves the encrypted administrator password
        /// for the instances running
        /// Windows.
        /// </remarks>
        public GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request)
        {
            return Invoke<GetPasswordDataResponse>(ConvertGetPasswordData(request));
        }

        /// <summary>
        /// Get Console Output 
        /// </summary>
        /// <param name="request">Get Console Output  request</param>
        /// <returns>Get Console Output  Response from the service</returns>
        /// <remarks>
        /// The GetConsoleOutput operation retrieves console
        /// output for the specified instance.
        /// Instance console output is buffered
        /// and posted shortly after instance boot,
        /// reboot, and termination. Amazon EC2 preserves the
        /// most recent 64 KB output which will be
        /// available for at least one hour after the most recent post.
        /// </remarks>
        public GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request)
        {
            return Invoke<GetConsoleOutputResponse>(ConvertGetConsoleOutput(request));
        }

        /// <summary>
        /// Modify Snapshot Attribute 
        /// </summary>
        /// <param name="request">Modify Snapshot Attribute  request</param>
        /// <returns>Modify Snapshot Attribute  Response from the service</returns>
        /// <remarks>
        /// Adds or remove permission settings for the
        /// specified snapshot.
        /// </remarks>
        public ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            return Invoke<ModifySnapshotAttributeResponse>(ConvertModifySnapshotAttribute(request));
        }

        /// <summary>
        /// Modify Image Attribute 
        /// </summary>
        /// <param name="request">Modify Image Attribute  request</param>
        /// <returns>Modify Image Attribute  Response from the service</returns>
        /// <remarks>
        /// The ModifyImageAttribute operation modifies an
        /// attribute of an AMI.
        /// </remarks>
        public ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            return Invoke<ModifyImageAttributeResponse>(ConvertModifyImageAttribute(request));
        }

        /// <summary>
        /// Purchase Reserved Instances Offering 
        /// </summary>
        /// <param name="request">Purchase Reserved Instances Offering  request</param>
        /// <returns>Purchase Reserved Instances Offering  Response from the service</returns>
        /// <remarks>
        /// The PurchaseReservedInstancesOffering operation
        /// purchases a Reserved Instance for use with your account.
        /// With Amazon EC2 Reserved Instances, you purchase the
        /// right to launch Amazon EC2 instances for a period of time
        /// (without getting insufficient capacity errors) and pay a
        /// lower usage rate for the actual time used.
        /// </remarks>
        public PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
        {
            return Invoke<PurchaseReservedInstancesOfferingResponse>(ConvertPurchaseReservedInstancesOffering(request));
        }

        /// <summary>
        /// Reboot Instances 
        /// </summary>
        /// <param name="request">Reboot Instances  request</param>
        /// <returns>Reboot Instances  Response from the service</returns>
        /// <remarks>
        /// The RebootInstances operation requests a reboot
        /// of one or more instances. This
        /// operation is asynchronous; it only
        /// queues a request to reboot the specified
        /// instance(s). The operation
        /// will succeed if the instances are valid
        /// and belong to the user.
        /// Requests to reboot terminated instances are ignored.
        /// </remarks>
        public RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
        {
            return Invoke<RebootInstancesResponse>(ConvertRebootInstances(request));
        }

        /// <summary>
        /// Register Image 
        /// </summary>
        /// <param name="request">Register Image  request</param>
        /// <returns>Register Image  Response from the service</returns>
        /// <remarks>
        /// The RegisterImage operation registers an AMI with
        /// Amazon EC2. Images must be
        /// registered before they can be launched. For
        /// more information, see RunInstances.
        /// Each AMI is associated with an
        /// unique ID which is provided by the Amazon EC2
        /// service through the RegisterImage operation.
        /// During registration, Amazon EC2
        /// retrieves the specified image manifest from
        /// Amazon S3 and verifies that the image
        /// is owned by the user registering the image.
        /// The image manifest is retrieved once and stored within the Amazon EC2.
        /// Any modifications to an image in Amazon S3 invalidates this
        /// registration. If you make changes to an image, deregister the
        /// previous image and register the new
        /// image. For more information, see DeregisterImage.
        /// </remarks>
        public RegisterImageResponse RegisterImage(RegisterImageRequest request)
        {
            return Invoke<RegisterImageResponse>(ConvertRegisterImage(request));
        }

        /// <summary>
        /// Release Address 
        /// </summary>
        /// <param name="request">Release Address  request</param>
        /// <returns>Release Address  Response from the service</returns>
        /// <remarks>
        /// The ReleaseAddress operation releases an elastic
        /// IP address associated with your account.
        /// Note:
        /// Releasing an IP address
        /// automatically disassociates it from any instance with
        /// which it is associated. For more information, see
        /// DisassociateAddress.
        /// Important:
        /// After releasing an elastic IP address, it is released to the IP
        /// address pool and might no longer be available to your account. Make
        /// sure to update your DNS records and any servers or devices that
        /// communicate with the address.
        /// If you run this operation on an elastic
        /// IP address that is already released,
        /// the address might be assigned to
        /// another account which will cause
        /// Amazon EC2 to return an error.
        /// </remarks>
        public ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request)
        {
            return Invoke<ReleaseAddressResponse>(ConvertReleaseAddress(request));
        }

        /// <summary>
        /// Reset Snapshot Attribute 
        /// </summary>
        /// <param name="request">Reset Snapshot Attribute  request</param>
        /// <returns>Reset Snapshot Attribute  Response from the service</returns>
        /// <remarks>
        /// Resets permission settings for the specified
        /// snapshot.
        /// </remarks>
        public ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request)
        {
            return Invoke<ResetSnapshotAttributeResponse>(ConvertResetSnapshotAttribute(request));
        }

        /// <summary>
        /// Reset Image Attribute 
        /// </summary>
        /// <param name="request">Reset Image Attribute  request</param>
        /// <returns>Reset Image Attribute  Response from the service</returns>
        /// <remarks>
        /// The ResetImageAttribute operation resets an
        /// attribute of an AMI to its default value.
        /// Note:
        /// The productCodes
        /// attribute cannot be reset.
        /// </remarks>
        public ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request)
        {
            return Invoke<ResetImageAttributeResponse>(ConvertResetImageAttribute(request));
        }

        /// <summary>
        /// Revoke Security Group Ingress 
        /// </summary>
        /// <param name="request">Revoke Security Group Ingress  request</param>
        /// <returns>Revoke Security Group Ingress  Response from the service</returns>
        /// <remarks>
        /// The RevokeSecurityGroupIngress operation revokes
        /// permissions from a security
        /// group. The permissions used to revoke must
        /// be specified using the same values
        /// used to grant the permissions.
        /// Permissions are specified by IP protocol (TCP, UDP, or ICMP), the
        /// source of the request (by IP range or an Amazon EC2 user-group pair),
        /// the source and destination port ranges (for TCP and UDP), and the ICMP
        /// codes and types (for ICMP).
        /// Permission changes are quickly propagated
        /// to instances within the security
        /// group. However, depending on the
        /// number of instances in the group, a
        /// small delay is might occur, .
        /// When revoking a user/group pair permission, GroupName,
        /// SourceSecurityGroupName
        /// and SourceSecurityGroupOwnerId must be
        /// specified. When authorizing a
        /// CIDR IP permission, GroupName,
        /// IpProtocol, FromPort, ToPort and CidrIp must be
        /// specified. Mixing these two types of parameters is not allowed.
        /// </remarks>
        public RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request)
        {
            return Invoke<RevokeSecurityGroupIngressResponse>(ConvertRevokeSecurityGroupIngress(request));
        }

        /// <summary>
        /// Run Instances 
        /// </summary>
        /// <param name="request">Run Instances  request</param>
        /// <returns>Run Instances  Response from the service</returns>
        /// <remarks>
        /// The RunInstances operation launches a specified
        /// number of instances.
        /// If Amazon EC2 cannot launch the minimum number
        /// AMIs you request, no instances
        /// launch. If there is insufficient
        /// capacity to launch the maximum number of AMIs
        /// you request, Amazon EC2
        /// launches as many as possible to satisfy the
        /// requested maximum values.
        /// Every instance is launched in a security group. If you do not
        /// specify a security group at launch, the instances start in your
        /// default security group. For more information on creating security
        /// groups, see CreateSecurityGroup.
        /// An optional instance type can be
        /// specified. For information about
        /// instance types, see Instance Types.
        /// You can provide an optional key pair ID for each image in the launch
        /// request (for more information, see CreateKeyPair). All instances that
        /// are created from images that use this key pair will have access to the
        /// associated public key at boot. You can use this key to provide secure
        /// access to an instance of an image on a per-instance basis. Amazon EC2
        /// public images use this feature to provide secure access without passwords.
        /// Important:
        /// Launching public images without a key pair ID will leave them inaccessible.
        /// The public key material is made available to the instance at boot
        /// time by placing it in the openssh_id.pub file on a logical device that is exposed
        /// to the instance as /dev/sda2 (the ephemeral store). The format of this
        /// file is suitable for use as an entry within ~/.ssh/authorized_keys (the
        /// OpenSSH format). This can be done at boot (e.g., as part of rc.local)
        /// allowing for secure access without passwords.
        /// Optional user data can be provided in the launch request. All instances that
        /// collectively comprise the launch request have access to this data
        /// For more information, see Instance Metadata.
        /// Note:
        /// If any of the AMIs have a product code attached for which the user has
        /// not subscribed, the RunInstances call will fail.
        /// Important:
        /// We strongly recommend using
        /// the 2.6.18 Xen stock kernel with the
        /// c1.medium and c1.xlarge
        /// instances. Although the default Amazon EC2 kernels will work, the
        /// new kernels provide greater stability and performance for these
        /// instance types. For more information about kernels, see Kernels, RAM
        /// Disks, and Block Device Mappings.
        /// </remarks>
        public RunInstancesResponse RunInstances(RunInstancesRequest request)
        {
            return Invoke<RunInstancesResponse>(ConvertRunInstances(request));
        }

        /// <summary>
        /// Stop Instances 
        /// </summary>
        /// <param name="request">Stop Instances  request</param>
        /// <returns>Stop Instances  Response from the service</returns>
        /// <remarks>
        /// Stops an instance that uses an Amazon EBS volume
        /// as its root device. Instances that use Amazon EBS volumes as their
        /// root devices can be quickly stopped and started.
        /// When an instance is stopped, the compute resources are released and you
        /// are not billed for hourly
        /// instance usage. However, your root partition Amazon EBS
        /// volume remains, continues to persist your
        /// data, and you are charged for Amazon EBS volume usage. You can restart
        /// your instance at any time.
        /// </remarks>
        public StopInstancesResponse StopInstances(StopInstancesRequest request)
        {
            return Invoke<StopInstancesResponse>(ConvertStopInstances(request));
        }

        /// <summary>
        /// Start Instances 
        /// </summary>
        /// <param name="request">Start Instances  request</param>
        /// <returns>Start Instances  Response from the service</returns>
        /// <remarks>
        /// Starts an instance that uses an Amazon EBS volume as its root device.
        /// Instances that use Amazon EBS volumes as their root devices can be
        /// quickly stopped and started. When an instance is
        /// stopped, the compute resources are released and you
        /// are not billed for hourly instance usage. However, your root
        /// partition Amazon EBS volume remains, continues to persist your
        /// data, and you are charged for Amazon EBS volume usage. You can restart
        /// your instance at any time.
        /// </remarks>
        public StartInstancesResponse StartInstances(StartInstancesRequest request)
        {
            return Invoke<StartInstancesResponse>(ConvertStartInstances(request));
        }

        /// <summary>
        /// Modify Instance Attribute 
        /// </summary>
        /// <param name="request">Modify Instance Attribute  request</param>
        /// <returns>Modify Instance Attribute  Response from the service</returns>
        /// <remarks>
        /// Modifies an attribute of an instance.
        /// </remarks>
        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            return Invoke<ModifyInstanceAttributeResponse>(ConvertModifyInstanceAttribute(request));
        }

        /// <summary>
        /// Reset Instance Attribute 
        /// </summary>
        /// <param name="request">Reset Instance Attribute  request</param>
        /// <returns>Reset Instance Attribute  Response from the service</returns>
        /// <remarks>
        /// Resets an attribute of an instance to its default
        /// value.
        /// </remarks>
        public ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request)
        {
            return Invoke<ResetInstanceAttributeResponse>(ConvertResetInstanceAttribute(request));
        }

        /// <summary>
        /// Describe Instance Attribute 
        /// </summary>
        /// <param name="request">Describe Instance Attribute  request</param>
        /// <returns>Describe Instance Attribute  Response from the service</returns>
        /// <remarks>
        /// Returns information about an attribute of an
        /// instance. Only one attribute
        /// can be specified per call.
        /// </remarks>
        public DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            return Invoke<DescribeInstanceAttributeResponse>(ConvertDescribeInstanceAttribute(request));
        }

        /// <summary>
        /// Terminate Instances 
        /// </summary>
        /// <param name="request">Terminate Instances  request</param>
        /// <returns>Terminate Instances  Response from the service</returns>
        /// <remarks>
        /// The TerminateInstances operation shuts down one
        /// or more instances. This
        /// operation is idempotent; if you terminate an
        /// instance more than
        /// once, each call
        /// will succeed.
        /// Terminated instances
        /// will remain visible after termination (approximately one hour).
        /// </remarks>
        public TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request)
        {
            return Invoke<TerminateInstancesResponse>(ConvertTerminateInstances(request));
        }

        /// <summary>
        /// Monitor Instances 
        /// </summary>
        /// <param name="request">Monitor Instances  request</param>
        /// <returns>Monitor Instances  Response from the service</returns>
        /// <remarks>
        /// Enables monitoring for a running instance.
        /// </remarks>
        public MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request)
        {
            return Invoke<MonitorInstancesResponse>(ConvertMonitorInstances(request));
        }

        /// <summary>
        /// Unmonitor Instances 
        /// </summary>
        /// <param name="request">Unmonitor Instances  request</param>
        /// <returns>Unmonitor Instances  Response from the service</returns>
        /// <remarks>
        /// Disables monitoring for a running instance.
        /// </remarks>
        public UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request)
        {
            return Invoke<UnmonitorInstancesResponse>(ConvertUnmonitorInstances(request));
        }

        /// <summary>
        /// Describe Vpn Connections 
        /// </summary>
        /// <param name="request">Describe Vpn Connections  request</param>
        /// <returns>Describe Vpn Connections  Response from the service</returns>
        /// <remarks>
        /// Gives you information about your VPN connections.
        /// Important -
        /// We strongly recommend you use HTTPS when calling this operation because the
        /// response contains sensitive cryptographic information for configuring your customer gateway.
        /// You can filter the results to return information only about VPN connections
        /// that match criteria you specify. For example, you could ask to get information
        /// about a particular VPN connection (or all) only if the VPN's state is pending
        /// or available. You can specify multiple filters (e.g., the VPN connection is
        /// associated with a particular VPN gateway, and the gateway's state is
        /// pending or available). The result includes information for a particular
        /// VPN connection only if the VPN connection matches all your filters.
        /// If there's no match, no special message is returned; the response is
        /// simply empty.
        /// </remarks>
        public DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request)
        {
            return Invoke<DescribeVpnConnectionsResponse>(ConvertDescribeVpnConnections(request));
        }

        /// <summary>
        /// Describe Subnets 
        /// </summary>
        /// <param name="request">Describe Subnets  request</param>
        /// <returns>Describe Subnets  Response from the service</returns>
        /// <remarks>
        /// Gives you information about your subnets. You can filter the results to
        /// return information only about subnets that match criteria you specify.
        /// For example, you could ask to get information about a particular subnet
        /// (or all) only if the subnet's state is available. You can specify multiple
        /// filters (e.g., the subnet is in a particular VPC, and the subnet's state is
        /// available). The result includes information for a particular subnet only
        /// if the subnet matches all your filters. If there's no match, no special
        /// message is returned; the response is simply empty. The following table
        /// shows the available filters.
        /// </remarks>
        public DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request)
        {
            return Invoke<DescribeSubnetsResponse>(ConvertDescribeSubnets(request));
        }

        /// <summary>
        /// Detach Vpn Gateway 
        /// </summary>
        /// <param name="request">Detach Vpn Gateway  request</param>
        /// <returns>Detach Vpn Gateway  Response from the service</returns>
        /// <remarks>
        /// Detaches a VPN gateway from a VPC. You do this if you're planning to
        /// turn off the VPC and not use it anymore. You can confirm a VPN gateway
        /// has been completely detached from a VPC by describing the VPN gateway
        /// (any attachments to the VPN gateway are also described).
        /// You must wait for the attachment's state to switch to detached before you can
        /// delete the VPC or attach a different VPC to the VPN gateway.
        /// </remarks>
        public DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request)
        {
            return Invoke<DetachVpnGatewayResponse>(ConvertDetachVpnGateway(request));
        }

        /// <summary>
        /// Describe Vpcs 
        /// </summary>
        /// <param name="request">Describe Vpcs  request</param>
        /// <returns>Describe Vpcs  Response from the service</returns>
        /// <remarks>
        /// Gives you information about your VPCs. You can filter the results to return
        /// information only about VPCs that match criteria you specify. For example,
        /// you could ask to get information about a particular VPC or VPCs (or all your VPCs)
        /// only if the VPC's state is available. You can specify multiple filters (e.g.,
        /// the VPC uses one of several sets of DHCP options, and the VPC's state is available).
        /// The result includes information for a particular VPC only if the VPC
        /// matches all your filters. If there's no match, no special message is
        /// returned; the response is simply empty.
        /// </remarks>
        public DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            return Invoke<DescribeVpcsResponse>(ConvertDescribeVpcs(request));
        }

        /// <summary>
        /// Delete Customer Gateway 
        /// </summary>
        /// <param name="request">Delete Customer Gateway  request</param>
        /// <returns>Delete Customer Gateway  Response from the service</returns>
        /// <remarks>
        /// Deletes a customer gateway. You must delete the VPN connection before
        /// deleting the customer gateway.
        /// AWS might delete any customer gateway if you leave it inactive for an extended
        /// period of time (inactive means that there's no VPN connection in use with the
        /// customer gateway).
        /// </remarks>
        public DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request)
        {
            return Invoke<DeleteCustomerGatewayResponse>(ConvertDeleteCustomerGateway(request));
        }

        /// <summary>
        /// Attach Vpn Gateway 
        /// </summary>
        /// <param name="request">Attach Vpn Gateway  request</param>
        /// <returns>Attach Vpn Gateway  Response from the service</returns>
        /// <remarks>
        /// Attaches a VPN gateway to a VPC. This is the last step required to get your
        /// VPC fully connected to your data center before launching instances in it.
        /// For more information, go to Process for Using Amazon VPC in the Amazon Virtual
        /// Private Cloud Developer Guide.
        /// </remarks>
        public AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request)
        {
            return Invoke<AttachVpnGatewayResponse>(ConvertAttachVpnGateway(request));
        }

        /// <summary>
        /// Delete Dhcp Options 
        /// </summary>
        /// <param name="request">Delete Dhcp Options  request</param>
        /// <returns>Delete Dhcp Options  Response from the service</returns>
        /// <remarks>
        /// Deletes a set of DHCP options that you specify. Amazon VPC returns an error if the
        /// set of options you specify is currently associated with a VPC. You can disassociate
        /// the set of options by associating either a new set of options or the default options with the VPC.
        /// </remarks>
        public DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request)
        {
            return Invoke<DeleteDhcpOptionsResponse>(ConvertDeleteDhcpOptions(request));
        }

        /// <summary>
        /// Delete Subnet 
        /// </summary>
        /// <param name="request">Delete Subnet  request</param>
        /// <returns>Delete Subnet  Response from the service</returns>
        /// <remarks>
        /// Deletes a subnet from a VPC. You must terminate all running instances in the
        /// subnet before deleting it, otherwise Amazon VPC returns an error.
        /// AWS might delete any subnet if you leave it inactive for an extended period
        /// of time (inactive means that there are no running Amazon EC2 instances in the subnet).
        /// </remarks>
        public DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request)
        {
            return Invoke<DeleteSubnetResponse>(ConvertDeleteSubnet(request));
        }

        /// <summary>
        /// Create Vpc 
        /// </summary>
        /// <param name="request">Create Vpc  request</param>
        /// <returns>Create Vpc  Response from the service</returns>
        /// <remarks>
        /// Creates a VPC with the CIDR block you specify. The smallest VPC you can create
        /// uses a /28 netmask (16 IP addresses), and the largest uses a /18 netmask
        /// (16,384 IP addresses). To help you decide how big to make your VPC, go
        /// to the topic about creating VPCs  in the Amazon Virtual Private Cloud
        /// Developer Guide.
        /// By default, each instance you launch in the VPC has the default DHCP options
        /// (the standard EC2 host name, no domain name, no DNS server, no NTP server, and
        /// no NetBIOS server or node type).
        /// AWS might delete any VPC that you create with this operation if you leave it inactive
        /// for an extended period of time (inactive means that there are no running Amazon EC2
        /// instances in the VPC).
        /// </remarks>
        public CreateVpcResponse CreateVpc(CreateVpcRequest request)
        {
            return Invoke<CreateVpcResponse>(ConvertCreateVpc(request));
        }

        /// <summary>
        /// Create Customer Gateway 
        /// </summary>
        /// <param name="request">Create Customer Gateway  request</param>
        /// <returns>Create Customer Gateway  Response from the service</returns>
        /// <remarks>
        /// Provides information to AWS about your customer gateway device.
        /// The customer gateway is the appliance at your end of the VPN connection
        /// (compared to the VPN gateway, which is the device at the AWS side of the VPN
        /// connection). AWS might delete any customer gateway that you create with this
        /// operation if you leave it inactive for an extended period of time (inactive means
        /// that there's no VPN connection in use with the customer gateway).
        /// You must provide the Internet-routable IP address of the customer gateway's external
        /// interface. The IP address must be static and can't be behind a device performing
        /// network address translation (NAT).
        /// You must also provide the device's Border Gateway Protocol (BGP) Autonomous
        /// System Number (ASN). You can use an existing ASN assigned to your network.
        /// If you don't have an ASN already, you can use a private ASN (in the 64512 - 65534 range).
        /// For more information about ASNs, go to the Wikipedia article -
        /// http://en.wikipedia.org/wiki/Autonomous_system_%28Internet%29.
        /// </remarks>
        public CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request)
        {
            return Invoke<CreateCustomerGatewayResponse>(ConvertCreateCustomerGateway(request));
        }

        /// <summary>
        /// Create Vpn Gateway 
        /// </summary>
        /// <param name="request">Create Vpn Gateway  request</param>
        /// <returns>Create Vpn Gateway  Response from the service</returns>
        /// <remarks>
        /// Creates a new VPN gateway. A VPN gateway is the VPC-side endpoint for
        /// your VPN connection. You can create a VPN gateway before creating the VPC
        /// itself. AWS might delete any VPN gateway that you create with this operation
        /// if you leave it inactive for an extended period of time (inactive means
        /// that there's no VPN connection in use with the VPN gateway).
        /// </remarks>
        public CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request)
        {
            return Invoke<CreateVpnGatewayResponse>(ConvertCreateVpnGateway(request));
        }

        /// <summary>
        /// Delete Vpc 
        /// </summary>
        /// <param name="request">Delete Vpc  request</param>
        /// <returns>Delete Vpc  Response from the service</returns>
        /// <remarks>
        /// Deletes a VPC. You must terminate all running instances and delete all
        /// subnets before deleting the VPC, otherwise Amazon VPC returns an error.
        /// AWS might delete any VPC if you leave it inactive for an extended period of time
        /// (inactive means that there are no running Amazon EC2 instances in the VPC).
        /// </remarks>
        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
        {
            return Invoke<DeleteVpcResponse>(ConvertDeleteVpc(request));
        }

        /// <summary>
        /// Associate Dhcp Options 
        /// </summary>
        /// <param name="request">Associate Dhcp Options  request</param>
        /// <returns>Associate Dhcp Options  Response from the service</returns>
        /// <remarks>
        /// Associates a set of DHCP options (that you've previously created) with the specified VPC.
        /// Or, associates the default DHCP options with the VPC. The default set consists of the standard
        /// EC2 host name, no domain name, no DNS server, no NTP server, and no NetBIOS server or node type.
        /// After you associate the options with the VPC, any existing instances and all new instances
        /// that you launch in that VPC use the options. For more information about the supported DHCP
        /// options and using them with Amazon VPC, go to Using DHCP Options in the Amazon Virtual
        /// Private Cloud Developer Guide.
        /// </remarks>
        public AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request)
        {
            return Invoke<AssociateDhcpOptionsResponse>(ConvertAssociateDhcpOptions(request));
        }

        /// <summary>
        /// Describe Vpn Gateways 
        /// </summary>
        /// <param name="request">Describe Vpn Gateways  request</param>
        /// <returns>Describe Vpn Gateways  Response from the service</returns>
        /// <remarks>
        /// Gives you information about your VPN gateways. You can filter the results to return
        /// information only about VPN gateways that match criteria you specify. For example,
        /// you could ask to get information about a particular VPN gateway (or all) only if the
        /// gateway's state is pending or available. You can specify multiple filters (e.g., the
        /// VPN gateway is in a particular Availability Zone and the gateway's state is pending or
        /// available). The result includes information for a particular VPN gateway only if the
        /// gateway matches all your filters. If there's no match, no special message is returned;
        /// the response is simply empty.
        /// </remarks>
        public DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request)
        {
            return Invoke<DescribeVpnGatewaysResponse>(ConvertDescribeVpnGateways(request));
        }

        /// <summary>
        /// Create Subnet 
        /// </summary>
        /// <param name="request">Create Subnet  request</param>
        /// <returns>Create Subnet  Response from the service</returns>
        /// <remarks>
        /// Creates a subnet in an existing VPC. You can create up to 20 subnets in a VPC.
        /// If you add more than one subnet to a VPC, they're set up in a star topology with
        /// a logical router in the middle. If you feel you need more than 20 subnets, you can
        /// request more by going to http://aws.amazon.com/contact-us/vpc-request/.
        /// When you create each subnet, you provide the VPC ID and the CIDR block you
        /// want for the subnet. Once you create a subnet, you can't change its CIDR block.
        /// The subnet's CIDR block can be the same as the VPC's CIDR block (assuming you
        /// want only a single subnet in the VPC), or a subset of the VPC's CIDR block.
        /// If you create more than one subnet in a VPC, the subnets' CIDR blocks must not overlap.
        /// The smallest subnet (and VPC) you can create uses a /28 netmask (16 IP addresses),
        /// and the largest uses a /18 netmask (16,384 IP addresses).
        /// Important -
        /// AWS reserves both the first four and the last IP address in each subnet's CIDR block.
        /// They're not available for use.
        /// AWS might delete any subnet you create with this operation if you leave it inactive
        /// for an extended period of time (inactive means that there are no running Amazon EC2
        /// instances in the subnet).
        /// </remarks>
        public CreateSubnetResponse CreateSubnet(CreateSubnetRequest request)
        {
            return Invoke<CreateSubnetResponse>(ConvertCreateSubnet(request));
        }

        /// <summary>
        /// Delete Vpn Connection 
        /// </summary>
        /// <param name="request">Delete Vpn Connection  request</param>
        /// <returns>Delete Vpn Connection  Response from the service</returns>
        /// <remarks>
        /// Deletes a VPN connection. Use this if you want to delete a VPC and
        /// all its associated components. Another reason to use this operation
        /// is if you believe the tunnel credentials for your VPN connection have
        /// been compromised. In that situation, you can delete the VPN connection
        /// and create a new one that has new keys, without needing to delete the
        /// VPC or VPN gateway. If you create a new VPN connection, you must
        /// reconfigure the customer gateway using the new configuration
        /// information returned with the new VPN connection ID.
        /// If you're deleting the VPC and all its associated parts, we recommend you
        /// detach the VPN gateway from the VPC and delete the VPC before deleting
        /// the VPN connection.
        /// </remarks>
        public DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request)
        {
            return Invoke<DeleteVpnConnectionResponse>(ConvertDeleteVpnConnection(request));
        }

        /// <summary>
        /// Delete Vpn Gateway 
        /// </summary>
        /// <param name="request">Delete Vpn Gateway  request</param>
        /// <returns>Delete Vpn Gateway  Response from the service</returns>
        /// <remarks>
        /// Deletes a VPN gateway. Use this when you want to delete a VPC and all
        /// its associated components because you no longer need them. We recommend
        /// that before you delete a VPN gateway, you detach it from the VPC and
        /// delete the VPN connection. Note that you don't need to delete the VPN
        /// gateway if you just want to delete and re-create the VPN connection
        /// between your VPC and data center.
        /// AWS might delete any VPN gateway if you leave it inactive for an extended period of time
        /// (inactive means that there's no VPN connection in use with the VPN gateway).
        /// </remarks>
        public DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request)
        {
            return Invoke<DeleteVpnGatewayResponse>(ConvertDeleteVpnGateway(request));
        }

        /// <summary>
        /// Describe Customer Gateways 
        /// </summary>
        /// <param name="request">Describe Customer Gateways  request</param>
        /// <returns>Describe Customer Gateways  Response from the service</returns>
        /// <remarks>
        /// Gives you information about your customer gateways. You can filter the results to return
        /// information only about customer gateways that match criteria you specify. For example,
        /// you could ask to get information about a particular customer gateway (or all) only if
        /// the gateway's state is pending or available. You can specify multiple filters (e.g.,
        /// the customer gateway has a particular IP address for the Internet-routable external
        /// interface, and the gateway's state is pending or available). The result includes
        /// information for a particular customer gateway only if the gateway matches all  your
        /// filters. If there's no match, no special message is returned; the response is simply empty.
        /// </remarks>
        public DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
        {
            return Invoke<DescribeCustomerGatewaysResponse>(ConvertDescribeCustomerGateways(request));
        }

        /// <summary>
        /// Create Vpn Connection 
        /// </summary>
        /// <param name="request">Create Vpn Connection  request</param>
        /// <returns>Create Vpn Connection  Response from the service</returns>
        /// <remarks>
        /// Creates a new VPN connection between an existing VPN gateway and customer
        /// gateway. The only supported connection type is ipsec.1.
        /// The response includes information that you need to configure your customer gateway,
        /// in XML format. We recommend you use the command line version of this operation
        /// (ec2-create-vpn-connection), which lets you get the configuration information
        /// formatted in a friendlier way. For information about the command, go to
        /// ec2-create-vpn-connection in the Amazon Virtual Private Cloud Command Line Reference.
        /// Important -
        /// We strongly recommend you use HTTPS when calling this operation because
        /// the response contains sensitive cryptographic information for configuring
        /// your customer gateway.
        /// If you decide to shut down your VPN connection for any reason and then create a new
        /// one, you must re-configure your customer gateway with the new information
        /// returned from this call.
        /// </remarks>
        public CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request)
        {
            return Invoke<CreateVpnConnectionResponse>(ConvertCreateVpnConnection(request));
        }

        /// <summary>
        /// Describe Dhcp Options 
        /// </summary>
        /// <param name="request">Describe Dhcp Options  request</param>
        /// <returns>Describe Dhcp Options  Response from the service</returns>
        /// <remarks>
        /// Gives you information about one or more sets of DHCP options. You can specify
        /// one or more DHCP options set IDs, or no IDs (to describe all your sets of DHCP options).
        /// The returned information consists of:
        /// - The DHCP options set ID
        /// - The options
        /// </remarks>
        public DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request)
        {
            return Invoke<DescribeDhcpOptionsResponse>(ConvertDescribeDhcpOptions(request));
        }

        /// <summary>
        /// Create Dhcp Options 
        /// </summary>
        /// <param name="request">Create Dhcp Options  request</param>
        /// <returns>Create Dhcp Options  Response from the service</returns>
        /// <remarks>
        /// Creates a set of DHCP options that you can then associate with one or more VPCs,
        /// causing all existing and new instances that you launch in those VPCs to use the
        /// set of DHCP options. The following table lists the individual DHCP options you can
        /// specify. For more information about the options, go to RFC 2132 - http://www.ietf.org/rfc/rfc2132.txt
        /// </remarks>
        public CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request)
        {
            return Invoke<CreateDhcpOptionsResponse>(ConvertCreateDhcpOptions(request));
        }

        /// <summary>
        /// Request Spot Instances 
        /// </summary>
        /// <param name="request">Request Spot Instances  request</param>
        /// <returns>Request Spot Instances  Response from the service</returns>
        /// <remarks>
        /// Creates a Spot Instance request. Spot Instances are instances that automatically launch when your
        /// request price exceeds the Spot Price that Amazon EC2 periodically calculates.
        /// </remarks>
        public RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request)
        {
            return Invoke<RequestSpotInstancesResponse>(ConvertRequestSpotInstances(request));
        }

        /// <summary>
        /// Describe Spot Instance Requests 
        /// </summary>
        /// <param name="request">Describe Spot Instance Requests  request</param>
        /// <returns>Describe Spot Instance Requests  Response from the service</returns>
        /// <remarks>
        /// Describes Spot Instance requests. Spot Instances are instances that automatically launch when your
        /// request price exceeds the Spot Price that Amazon EC2 periodically calculates.
        /// </remarks>
        public DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request)
        {
            return Invoke<DescribeSpotInstanceRequestsResponse>(ConvertDescribeSpotInstanceRequests(request));
        }

        /// <summary>
        /// Cancel Spot Instance Requests 
        /// </summary>
        /// <param name="request">Cancel Spot Instance Requests  request</param>
        /// <returns>Cancel Spot Instance Requests  Response from the service</returns>
        /// <remarks>
        /// Cancels Spot Instance requests. Spot Instances are instances that automatically launch when your
        /// request price exceeds the Spot Price that Amazon EC2 periodically calculates.
        /// </remarks>
        public CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request)
        {
            return Invoke<CancelSpotInstanceRequestsResponse>(ConvertCancelSpotInstanceRequests(request));
        }

        /// <summary>
        /// Describe Spot Price History 
        /// </summary>
        /// <param name="request">Describe Spot Price History  request</param>
        /// <returns>Describe Spot Price History  Response from the service</returns>
        /// <remarks>
        /// Describes historical pricing for Spot Instances. Spot Instances are instances that automatically launch
        /// when your request price exceeds the Spot Price that Amazon EC2 periodically calculates.
        /// </remarks>
        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
        {
            return Invoke<DescribeSpotPriceHistoryResponse>(ConvertDescribeSpotPriceHistory(request));
        }

        /// <summary>
        /// Create Spot Datafeed Subscription 
        /// </summary>
        /// <param name="request">Create Spot Datafeed Subscription  request</param>
        /// <returns>Create Spot Datafeed Subscription  Response from the service</returns>
        /// <remarks>
        /// Creates the data feed for Spot Instances, enabling you to view Spot Instance usage logs. You can
        /// create one data feed per account.
        /// </remarks>
        public CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request)
        {
            return Invoke<CreateSpotDatafeedSubscriptionResponse>(ConvertCreateSpotDatafeedSubscription(request));
        }

        /// <summary>
        /// Describe Spot Datafeed Subscription 
        /// </summary>
        /// <param name="request">Describe Spot Datafeed Subscription  request</param>
        /// <returns>Describe Spot Datafeed Subscription  Response from the service</returns>
        /// <remarks>
        /// Describes the data feed for Spot Instances.
        /// </remarks>
        public DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request)
        {
            return Invoke<DescribeSpotDatafeedSubscriptionResponse>(ConvertDescribeSpotDatafeedSubscription(request));
        }

        /// <summary>
        /// Delete Spot Datafeed Subscription 
        /// </summary>
        /// <param name="request">Delete Spot Datafeed Subscription  request</param>
        /// <returns>Delete Spot Datafeed Subscription  Response from the service</returns>
        /// <remarks>
        /// Deletes the data feed for Spot Instances.
        /// </remarks>
        public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request)
        {
            return Invoke<DeleteSpotDatafeedSubscriptionResponse>(ConvertDeleteSpotDatafeedSubscription(request));
        }

        #endregion

        #region Private API

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonEC2Config instance
         */
        private static HttpWebRequest ConfigureWebRequest(int contentLength, AmazonEC2Config config)
        {
            HttpWebRequest request = WebRequest.Create(config.ServiceURL) as HttpWebRequest;
            if (request != null)
            {
                if (config.IsSetProxyHost() && config.IsSetProxyPort())
                {
                    WebProxy proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
                    if (config.IsSetProxyUsername())
                    {
                        proxy.Credentials = new NetworkCredential(
                            config.ProxyUsername,
                            config.ProxyPassword ?? String.Empty
                            );
                    }
                    request.Proxy = proxy;
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
            string actionName = parameters["Action"];
            T response = default(T);
            HttpStatusCode statusCode = default(HttpStatusCode);

            /* Add required request parameters */
            AddRequiredParameters(parameters);

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

                    /* Perform response transformation */
                    if (responseBody.Trim().EndsWith(String.Concat(actionName, "Response>")))
                    {
                        responseBody = Transform(responseBody, actionName, this.GetType());
                    }

                    /* Attempt to deserialize response into <Action> Response type */
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    using (XmlTextReader sr = new XmlTextReader(new StringReader(responseBody)))
                    {
                        response = (T)serializer.Deserialize(sr);
                    }
                    shouldRetry = false;
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
                        PauseOnRetry(++retries, maxRetries, statusCode);
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
                                throw ReportAnyErrors(responseBody, statusCode);
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

        /**
         * Look for additional error strings in the response and return formatted exception
         */
        private static AmazonEC2Exception ReportAnyErrors(string responseBody, HttpStatusCode status)
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
                    ex = new AmazonEC2Exception("Internal Error", status);
                }
            }
            else
            {
                ex = new AmazonEC2Exception("Internal Error", status);
            }
            return ex;
        }

        /**
         * Exponential sleep on failed request
         */
        private static void PauseOnRetry(int retries, int maxRetries, HttpStatusCode status)
        {
            if (retries <= maxRetries)
            {
                int delay = (int)Math.Pow(4, retries) * 100;
                System.Threading.Thread.Sleep(delay);
            }
            else
            {
                throw new AmazonEC2Exception(
                    "Maximum number of retry attempts reached : " + (retries - 1),
                    status
                    );
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<string, string> parameters)
        {
            if (String.IsNullOrEmpty(this.awsAccessKeyId))
            {
                throw new AmazonEC2Exception("The AWS Access Key ID cannot be NULL or a Zero length string");
            }

            parameters["AWSAccessKeyId"] = this.awsAccessKeyId;
            parameters["SignatureVersion"] = config.SignatureVersion;
            parameters["SignatureMethod"] = config.SignatureMethod;
            parameters["Timestamp"] = AWSSDKUtils.FormattedCurrentTimestampISO8601;
            parameters["Version"] = config.ServiceVersion;
            if (!config.SignatureVersion.Equals("2"))
            {
                throw new AmazonEC2Exception("Invalid Signature Version specified");
            }
            string toSign = AWSSDKUtils.CalculateStringToSignV2(parameters, config.ServiceURL);

            KeyedHashAlgorithm algorithm = KeyedHashAlgorithm.Create(config.SignatureMethod.ToUpper());
            string auth;

            if (config.UseSecureStringForAwsSecretKey)
            {
                auth = AWSSDKUtils.HMACSign(toSign, awsSecretAccessKey, algorithm);
            }
            else
            {
                auth = AWSSDKUtils.HMACSign(toSign, clearAwsSecretAccessKey, algorithm);
            }
            parameters["Signature"] = auth;
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
                parameters[String.Concat("ReservedInstancesId", ".", describeReservedInstancesOfferingsRequestReservedInstancesIdListIndex)] = describeReservedInstancesOfferingsRequestReservedInstancesId;
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
                parameters["Description"] = request.Description;
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
            if (request.IsSetAdditionalInfo())
            {
                parameters["AdditionalInfo"] = request.AdditionalInfo;
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

        /*
         *  Transforms response based on xslt template
         */
        private static string Transform(string responseBody, string action, Type t)
        {
            XslCompiledTransform transformer = new XslCompiledTransform();

            // Build the name of the xslt transform to apply to the response
            char[] seps = { ',' };

            Assembly assembly = Assembly.GetAssembly(t);
            string assemblyName = assembly.FullName;
            assemblyName = assemblyName.Split(seps)[0];

            string ns = t.Namespace;
            string resourceName = String.Concat(
                assemblyName,
                ".",
                ns,
                ".Model.",
                action,
                "Response.xslt"
                );

            using (XmlTextReader xmlReader = new XmlTextReader(assembly.GetManifestResourceStream(resourceName)))
            {
                transformer.Load(xmlReader);

                StringBuilder sb = new StringBuilder(1024);
                using (XmlTextReader xmlR = new XmlTextReader(new StringReader(responseBody)))
                {
                    using (StringWriter sw = new StringWriter(sb))
                    {
                        transformer.Transform(xmlR, null, sw);
                        return sb.ToString();
                    }
                }
            }
        }

        #endregion
    }
}
