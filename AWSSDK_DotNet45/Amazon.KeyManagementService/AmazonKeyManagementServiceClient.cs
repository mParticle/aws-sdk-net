/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.KeyManagementService.Model;
using Amazon.KeyManagementService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KeyManagementService
{
    /// <summary>
    /// Implementation for accessing KeyManagementService
    ///
    /// AWS Key Management Service 
    /// <para>
    /// AWS Key Management Service (AWS KMS) is an encryption and key management web service.
    /// This guide describes the AWS KMS operations that you can call programmatically. For
    /// general information about AWS KMS, see the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/">AWS
    /// Key Management Service Developer Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .Net, iOS, Android, etc.). The SDKs provide a
    /// convenient way to create programmatic access to AWS KMS and other AWS services. For
    /// example, the SDKs take care of tasks such as signing requests (see below), managing
    /// errors, and retrying requests automatically. For more information about the AWS SDKs,
    /// including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you use the AWS SDKs to make programmatic API calls to AWS KMS.
    /// </para>
    ///  
    /// <para>
    /// Clients must support TLS (Transport Layer Security) 1.0. We recommend TLS 1.2. Clients
    /// must also support cipher suites with Perfect Forward Secrecy (PFS) such as Ephemeral
    /// Diffie-Hellman (DHE) or Elliptic Curve Ephemeral Diffie-Hellman (ECDHE). Most modern
    /// systems such as Java 7 and later support these modes. 
    /// </para>
    ///  
    /// <para>
    /// <b>Signing Requests</b>
    /// </para>
    ///  
    /// <para>
    /// Requests must be signed by using an access key ID and a secret access key. We strongly
    /// recommend that you <i>do not</i> use your AWS account access key ID and secret key
    /// for everyday work with AWS KMS. Instead, use the access key ID and secret access key
    /// for an IAM user, or you can use the AWS Security Token Service to generate temporary
    /// security credentials that you can use to sign requests.
    /// </para>
    ///  
    /// <para>
    /// All AWS KMS operations require <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>.
    /// </para>
    ///  
    /// <para>
    /// <b>Logging API Requests</b>
    /// </para>
    ///  
    /// <para>
    /// AWS KMS supports AWS CloudTrail, a service that logs AWS API calls and related events
    /// for your AWS account and delivers them to an Amazon S3 bucket that you specify. By
    /// using the information collected by CloudTrail, you can determine what requests were
    /// made to AWS KMS, who made the request, when it was made, and so on. To learn more
    /// about CloudTrail, including how to turn it on and find your log files, see the <a
    /// href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/">AWS CloudTrail User
    /// Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// <b>Additional Resources</b>
    /// </para>
    ///  
    /// <para>
    /// For more information about credentials and request signing, see the following:
    /// </para>
    ///  <ul> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">AWS
    /// Security Credentials</a> - This topic provides general information about the types
    /// of credentials used for accessing AWS. </li> <li> <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/">AWS
    /// Security Token Service</a> - This guide describes how to create and use temporary
    /// security credentials. </li> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// AWS API Requests</a> - This set of topics walks you through the process of signing
    /// a request using an access key ID and a secret access key. </li> </ul> 
    /// <para>
    /// <b>Commonly Used APIs</b>
    /// </para>
    ///  
    /// <para>
    ///  Of the APIs discussed in this guide, the following will prove the most useful for
    /// most applications. You will likely perform actions other than these, such as creating
    /// keys and assigning policies, by using the console.
    /// </para>
    ///  <ul> <li><a>Encrypt</a></li> <li><a>Decrypt</a></li> <li><a>GenerateDataKey</a></li>
    /// <li><a>GenerateDataKeyWithoutPlaintext</a></li> </ul>
    /// </summary>
    public partial class AmazonKeyManagementServiceClient : AmazonServiceClient, IAmazonKeyManagementService
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonKeyManagementServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyManagementServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyManagementServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(AmazonKeyManagementServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKeyManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials and an
        /// AmazonKeyManagementServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials, AmazonKeyManagementServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyManagementServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKeyManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKeyManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CancelKeyDeletion

        /// <summary>
        /// Cancels the deletion of a customer master key (CMK). When this operation is successful,
        /// the CMK is set to the <code>Disabled</code> state. To enable a CMK, use <a>EnableKey</a>.
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a CMK, go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) for which to cancel deletion. To specify this value, use the unique key ID or the Amazon Resource Name (ARN) of the CMK. Examples: <ul> <li>Unique key ID: 1234abcd-12ab-34cd-56ef-1234567890ab</li> <li>Key ARN: arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</li> </ul>  To obtain the unique key ID and key ARN for a given CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public CancelKeyDeletionResponse CancelKeyDeletion(string keyId)
        {
            var request = new CancelKeyDeletionRequest();
            request.KeyId = keyId;
            return CancelKeyDeletion(request);
        }

        /// <summary>
        /// Cancels the deletion of a customer master key (CMK). When this operation is successful,
        /// the CMK is set to the <code>Disabled</code> state. To enable a CMK, use <a>EnableKey</a>.
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a CMK, go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelKeyDeletion service method.</param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest request)
        {
            var marshaller = new CancelKeyDeletionRequestMarshaller();
            var unmarshaller = CancelKeyDeletionResponseUnmarshaller.Instance;

            return Invoke<CancelKeyDeletionRequest,CancelKeyDeletionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelKeyDeletion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelKeyDeletion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelKeyDeletionRequestMarshaller();
            var unmarshaller = CancelKeyDeletionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelKeyDeletionRequest,CancelKeyDeletionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        /// <summary>
        /// Creates a display name for a customer master key. An alias can be used to identify
        /// a key and should be unique. The console enforces a one-to-one mapping between the
        /// alias and a key. An alias name can contain only alphanumeric characters, forward slashes
        /// (/), underscores (_), and dashes (-). An alias must start with the word "alias" followed
        /// by a forward slash (alias/). An alias that begins with "aws" after the forward slash
        /// (alias/aws...) is reserved by Amazon Web Services (AWS). 
        /// 
        ///  
        /// <para>
        /// The alias and the key it is mapped to must be in the same AWS account and the same
        /// region.
        /// </para>
        ///  
        /// <para>
        /// To map an alias to a different key, call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the display name. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved. </param>
        /// <param name="targetKeyId">An identifier of the key for which you are creating the alias. This value cannot be another alias but can be a globally unique identifier or a fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public CreateAliasResponse CreateAlias(string aliasName, string targetKeyId)
        {
            var request = new CreateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return CreateAlias(request);
        }

        /// <summary>
        /// Creates a display name for a customer master key. An alias can be used to identify
        /// a key and should be unique. The console enforces a one-to-one mapping between the
        /// alias and a key. An alias name can contain only alphanumeric characters, forward slashes
        /// (/), underscores (_), and dashes (-). An alias must start with the word "alias" followed
        /// by a forward slash (alias/). An alias that begins with "aws" after the forward slash
        /// (alias/aws...) is reserved by Amazon Web Services (AWS). 
        /// 
        ///  
        /// <para>
        /// The alias and the key it is mapped to must be in the same AWS account and the same
        /// region.
        /// </para>
        ///  
        /// <para>
        /// To map an alias to a different key, call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var marshaller = new CreateAliasRequestMarshaller();
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasRequest,CreateAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAliasRequestMarshaller();
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasRequest,CreateAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGrant

        /// <summary>
        /// Adds a grant to a key to specify who can use the key and under what conditions. Grants
        /// are alternate permission mechanisms to key policies.
        /// 
        ///  
        /// <para>
        /// For more information about grants, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant service method.</param>
        /// 
        /// <returns>The response from the CreateGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because a grant token provided as part of the request is
        /// invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public CreateGrantResponse CreateGrant(CreateGrantRequest request)
        {
            var marshaller = new CreateGrantRequestMarshaller();
            var unmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return Invoke<CreateGrantRequest,CreateGrantResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateGrantRequestMarshaller();
            var unmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGrantRequest,CreateGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateKey

        /// <summary>
        /// Creates a customer master key. Customer master keys can be used to encrypt small amounts
        /// of data (less than 4K) directly, but they are most commonly used to encrypt or envelope
        /// data keys that are then used to encrypt customer data. For more information about
        /// data keys, see <a>GenerateDataKey</a> and <a>GenerateDataKeyWithoutPlaintext</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKey service method.</param>
        /// 
        /// <returns>The response from the CreateKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported.
        /// </exception>
        public CreateKeyResponse CreateKey(CreateKeyRequest request)
        {
            var marshaller = new CreateKeyRequestMarshaller();
            var unmarshaller = CreateKeyResponseUnmarshaller.Instance;

            return Invoke<CreateKeyRequest,CreateKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateKeyRequestMarshaller();
            var unmarshaller = CreateKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyRequest,CreateKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Decrypt

        /// <summary>
        /// Decrypts ciphertext. Ciphertext is plaintext that has been previously encrypted by
        /// using any of the following functions: <ul> <li><a>GenerateDataKey</a></li> <li><a>GenerateDataKeyWithoutPlaintext</a></li>
        /// <li><a>Encrypt</a></li> </ul> 
        /// 
        ///  
        /// <para>
        /// Note that if a caller has been granted access permissions to all keys (through, for
        /// example, IAM user policies that grant <code>Decrypt</code> permission on all resources),
        /// then ciphertext encrypted by using keys in other accounts where the key grants access
        /// to the caller can be decrypted. To remedy this, we recommend that you do not grant
        /// <code>Decrypt</code> access in an IAM user policy. Instead grant <code>Decrypt</code>
        /// access only in key policies. If you must grant <code>Decrypt</code> access in an IAM
        /// user policy, you should scope the resource to specific keys or to specific trusted
        /// accounts. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Decrypt service method.</param>
        /// 
        /// <returns>The response from the Decrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// The request was rejected because the specified ciphertext has been corrupted or is
        /// otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because a grant token provided as part of the request is
        /// invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the key was not available. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public DecryptResponse Decrypt(DecryptRequest request)
        {
            var marshaller = new DecryptRequestMarshaller();
            var unmarshaller = DecryptResponseUnmarshaller.Instance;

            return Invoke<DecryptRequest,DecryptResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Decrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Decrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DecryptResponse> DecryptAsync(DecryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DecryptRequestMarshaller();
            var unmarshaller = DecryptResponseUnmarshaller.Instance;

            return InvokeAsync<DecryptRequest,DecryptResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias

        /// <summary>
        /// Deletes the specified alias. To map an alias to a different key, call <a>UpdateAlias</a>.
        /// </summary>
        /// <param name="aliasName">The alias to be deleted. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public DeleteAliasResponse DeleteAlias(string aliasName)
        {
            var request = new DeleteAliasRequest();
            request.AliasName = aliasName;
            return DeleteAlias(request);
        }

        /// <summary>
        /// Deletes the specified alias. To map an alias to a different key, call <a>UpdateAlias</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var marshaller = new DeleteAliasRequestMarshaller();
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAliasRequestMarshaller();
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeKey

        /// <summary>
        /// Provides detailed information about the specified customer master key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier, a fully specified ARN to either an alias or a key, or an alias name prefixed by "alias/". <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Alias ARN Example - arn:aws:kms:us-east-1:123456789012:alias/MyAliasName</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> <li>Alias Name Example - alias/MyAliasName</li> </ul> </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public DescribeKeyResponse DescribeKey(string keyId)
        {
            var request = new DescribeKeyRequest();
            request.KeyId = keyId;
            return DescribeKey(request);
        }

        /// <summary>
        /// Provides detailed information about the specified customer master key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey service method.</param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public DescribeKeyResponse DescribeKey(DescribeKeyRequest request)
        {
            var marshaller = new DescribeKeyRequestMarshaller();
            var unmarshaller = DescribeKeyResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyRequest,DescribeKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeKeyRequestMarshaller();
            var unmarshaller = DescribeKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyRequest,DescribeKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableKey

        /// <summary>
        /// Sets the state of a master key to disabled, thereby preventing its use for cryptographic
        /// operations. For more information about how key state affects the use of a master key,
        /// go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public DisableKeyResponse DisableKey(string keyId)
        {
            var request = new DisableKeyRequest();
            request.KeyId = keyId;
            return DisableKey(request);
        }

        /// <summary>
        /// Sets the state of a master key to disabled, thereby preventing its use for cryptographic
        /// operations. For more information about how key state affects the use of a master key,
        /// go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKey service method.</param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public DisableKeyResponse DisableKey(DisableKeyRequest request)
        {
            var marshaller = new DisableKeyRequestMarshaller();
            var unmarshaller = DisableKeyResponseUnmarshaller.Instance;

            return Invoke<DisableKeyRequest,DisableKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableKeyRequestMarshaller();
            var unmarshaller = DisableKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DisableKeyRequest,DisableKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableKeyRotation

        /// <summary>
        /// Disables rotation of the specified key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public DisableKeyRotationResponse DisableKeyRotation(string keyId)
        {
            var request = new DisableKeyRotationRequest();
            request.KeyId = keyId;
            return DisableKeyRotation(request);
        }

        /// <summary>
        /// Disables rotation of the specified key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation service method.</param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public DisableKeyRotationResponse DisableKeyRotation(DisableKeyRotationRequest request)
        {
            var marshaller = new DisableKeyRotationRequestMarshaller();
            var unmarshaller = DisableKeyRotationResponseUnmarshaller.Instance;

            return Invoke<DisableKeyRotationRequest,DisableKeyRotationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableKeyRotationResponse> DisableKeyRotationAsync(DisableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableKeyRotationRequestMarshaller();
            var unmarshaller = DisableKeyRotationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableKeyRotationRequest,DisableKeyRotationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableKey

        /// <summary>
        /// Marks a key as enabled, thereby permitting its use.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public EnableKeyResponse EnableKey(string keyId)
        {
            var request = new EnableKeyRequest();
            request.KeyId = keyId;
            return EnableKey(request);
        }

        /// <summary>
        /// Marks a key as enabled, thereby permitting its use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKey service method.</param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public EnableKeyResponse EnableKey(EnableKeyRequest request)
        {
            var marshaller = new EnableKeyRequestMarshaller();
            var unmarshaller = EnableKeyResponseUnmarshaller.Instance;

            return Invoke<EnableKeyRequest,EnableKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableKeyRequestMarshaller();
            var unmarshaller = EnableKeyResponseUnmarshaller.Instance;

            return InvokeAsync<EnableKeyRequest,EnableKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableKeyRotation

        /// <summary>
        /// Enables rotation of the specified customer master key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public EnableKeyRotationResponse EnableKeyRotation(string keyId)
        {
            var request = new EnableKeyRotationRequest();
            request.KeyId = keyId;
            return EnableKeyRotation(request);
        }

        /// <summary>
        /// Enables rotation of the specified customer master key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation service method.</param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public EnableKeyRotationResponse EnableKeyRotation(EnableKeyRotationRequest request)
        {
            var marshaller = new EnableKeyRotationRequestMarshaller();
            var unmarshaller = EnableKeyRotationResponseUnmarshaller.Instance;

            return Invoke<EnableKeyRotationRequest,EnableKeyRotationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableKeyRotationResponse> EnableKeyRotationAsync(EnableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableKeyRotationRequestMarshaller();
            var unmarshaller = EnableKeyRotationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableKeyRotationRequest,EnableKeyRotationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Encrypt

        /// <summary>
        /// Encrypts plaintext into ciphertext by using a customer master key. The <code>Encrypt</code>
        /// function has two primary use cases: <ul> <li>You can encrypt up to 4 KB of arbitrary
        /// data such as an RSA key, a database password, or other sensitive customer information.</li>
        /// <li>If you are moving encrypted data from one region to another, you can use this
        /// API to encrypt in the new region the plaintext data key that was used to encrypt the
        /// data in the original region. This provides you with an encrypted copy of the data
        /// key that can be decrypted in the new region and used there to decrypt the encrypted
        /// data. </li> </ul> 
        /// 
        ///  
        /// <para>
        /// Unless you are moving encrypted data from one region to another, you don't use this
        /// function to encrypt a generated data key within a region. You retrieve data keys already
        /// encrypted by calling the <a>GenerateDataKey</a> or <a>GenerateDataKeyWithoutPlaintext</a>
        /// function. Data keys don't need to be encrypted again by calling <code>Encrypt</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you want to encrypt data locally in your application, you can use the <code>GenerateDataKey</code>
        /// function to return a plaintext data encryption key and a copy of the key encrypted
        /// under the customer master key (CMK) of your choosing. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Encrypt service method.</param>
        /// 
        /// <returns>The response from the Encrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because a grant token provided as part of the request is
        /// invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified KeySpec parameter is not valid. The
        /// currently supported value is ENCRYPT/DECRYPT.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the key was not available. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public EncryptResponse Encrypt(EncryptRequest request)
        {
            var marshaller = new EncryptRequestMarshaller();
            var unmarshaller = EncryptResponseUnmarshaller.Instance;

            return Invoke<EncryptRequest,EncryptResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Encrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Encrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EncryptResponse> EncryptAsync(EncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EncryptRequestMarshaller();
            var unmarshaller = EncryptResponseUnmarshaller.Instance;

            return InvokeAsync<EncryptRequest,EncryptResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKey

        /// <summary>
        /// Generates a data key that you can use in your application to locally encrypt data.
        /// This call returns a plaintext version of the key in the <code>Plaintext</code> field
        /// of the response object and an encrypted copy of the key in the <code>CiphertextBlob</code>
        /// field. The key is encrypted by using the master key specified by the <code>KeyId</code>
        /// field. To decrypt the encrypted key, pass it to the <code>Decrypt</code> API. 
        /// 
        ///  
        /// <para>
        /// We recommend that you use the following pattern to locally encrypt data: call the
        /// <code>GenerateDataKey</code> API, use the key returned in the <code>Plaintext</code>
        /// response field to locally encrypt data, and then erase the plaintext data key from
        /// memory. Store the encrypted data key (contained in the <code>CiphertextBlob</code>
        /// field) alongside of the locally encrypted data. 
        /// </para>
        ///  <note>You should not call the <code>Encrypt</code> function to re-encrypt your data
        /// keys within a region. <code>GenerateDataKey</code> always returns the data key encrypted
        /// and tied to the customer master key that will be used to decrypt it. There is no need
        /// to decrypt it twice. </note> 
        /// <para>
        /// If you decide to use the optional <code>EncryptionContext</code> parameter, you must
        /// also store the context in full or at least store enough information along with the
        /// encrypted data to be able to reconstruct the context when submitting the ciphertext
        /// to the <code>Decrypt</code> API. It is a good practice to choose a context that you
        /// can reconstruct on the fly to better secure the ciphertext. For more information about
        /// how this parameter is used, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/encrypt-context.html">Encryption
        /// Context</a>. 
        /// </para>
        ///  
        /// <para>
        /// To decrypt data, pass the encrypted data key to the <code>Decrypt</code> API. <code>Decrypt</code>
        /// uses the associated master key to decrypt the encrypted data key and returns it as
        /// plaintext. Use the plaintext data key to locally decrypt your data and then erase
        /// the key from memory. You must specify the encryption context, if any, that you specified
        /// when you generated the key. The encryption context is logged by CloudTrail, and you
        /// can use this log to help track the use of particular data. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey service method.</param>
        /// 
        /// <returns>The response from the GenerateDataKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because a grant token provided as part of the request is
        /// invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified KeySpec parameter is not valid. The
        /// currently supported value is ENCRYPT/DECRYPT.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the key was not available. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public GenerateDataKeyResponse GenerateDataKey(GenerateDataKeyRequest request)
        {
            var marshaller = new GenerateDataKeyRequestMarshaller();
            var unmarshaller = GenerateDataKeyResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyRequest,GenerateDataKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GenerateDataKeyRequestMarshaller();
            var unmarshaller = GenerateDataKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataKeyRequest,GenerateDataKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKeyWithoutPlaintext

        /// <summary>
        /// Returns a data key encrypted by a customer master key without the plaintext copy of
        /// that key. Otherwise, this API functions exactly like <a>GenerateDataKey</a>. You can
        /// use this API to, for example, satisfy an audit requirement that an encrypted key be
        /// made available without exposing the plaintext copy of that key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext service method.</param>
        /// 
        /// <returns>The response from the GenerateDataKeyWithoutPlaintext service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because a grant token provided as part of the request is
        /// invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified KeySpec parameter is not valid. The
        /// currently supported value is ENCRYPT/DECRYPT.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the key was not available. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintext(GenerateDataKeyWithoutPlaintextRequest request)
        {
            var marshaller = new GenerateDataKeyWithoutPlaintextRequestMarshaller();
            var unmarshaller = GenerateDataKeyWithoutPlaintextResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyWithoutPlaintextRequest,GenerateDataKeyWithoutPlaintextResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKeyWithoutPlaintext operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextAsync(GenerateDataKeyWithoutPlaintextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GenerateDataKeyWithoutPlaintextRequestMarshaller();
            var unmarshaller = GenerateDataKeyWithoutPlaintextResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataKeyWithoutPlaintextRequest,GenerateDataKeyWithoutPlaintextResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateRandom

        /// <summary>
        /// Generates an unpredictable byte string.
        /// </summary>
        /// <param name="numberOfBytes">Integer that contains the number of bytes to generate. Common values are 128, 256, 512, 1024 and so on. The current limit is 1024 bytes. </param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        public GenerateRandomResponse GenerateRandom(int numberOfBytes)
        {
            var request = new GenerateRandomRequest();
            request.NumberOfBytes = numberOfBytes;
            return GenerateRandom(request);
        }

        /// <summary>
        /// Generates an unpredictable byte string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom service method.</param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        public GenerateRandomResponse GenerateRandom(GenerateRandomRequest request)
        {
            var marshaller = new GenerateRandomRequestMarshaller();
            var unmarshaller = GenerateRandomResponseUnmarshaller.Instance;

            return Invoke<GenerateRandomRequest,GenerateRandomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateRandom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GenerateRandomResponse> GenerateRandomAsync(GenerateRandomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GenerateRandomRequestMarshaller();
            var unmarshaller = GenerateRandomResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateRandomRequest,GenerateRandomResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetKeyPolicy

        /// <summary>
        /// Retrieves a policy attached to the specified key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// <param name="policyName">String that contains the name of the policy. Currently, this must be "default". Policy names can be discovered by calling <a>ListKeyPolicies</a>. </param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public GetKeyPolicyResponse GetKeyPolicy(string keyId, string policyName)
        {
            var request = new GetKeyPolicyRequest();
            request.KeyId = keyId;
            request.PolicyName = policyName;
            return GetKeyPolicy(request);
        }

        /// <summary>
        /// Retrieves a policy attached to the specified key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy service method.</param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public GetKeyPolicyResponse GetKeyPolicy(GetKeyPolicyRequest request)
        {
            var marshaller = new GetKeyPolicyRequestMarshaller();
            var unmarshaller = GetKeyPolicyResponseUnmarshaller.Instance;

            return Invoke<GetKeyPolicyRequest,GetKeyPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetKeyPolicyResponse> GetKeyPolicyAsync(GetKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetKeyPolicyRequestMarshaller();
            var unmarshaller = GetKeyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyPolicyRequest,GetKeyPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetKeyRotationStatus

        /// <summary>
        /// Retrieves a Boolean value that indicates whether key rotation is enabled for the specified
        /// key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public GetKeyRotationStatusResponse GetKeyRotationStatus(string keyId)
        {
            var request = new GetKeyRotationStatusRequest();
            request.KeyId = keyId;
            return GetKeyRotationStatus(request);
        }

        /// <summary>
        /// Retrieves a Boolean value that indicates whether key rotation is enabled for the specified
        /// key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus service method.</param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public GetKeyRotationStatusResponse GetKeyRotationStatus(GetKeyRotationStatusRequest request)
        {
            var marshaller = new GetKeyRotationStatusRequestMarshaller();
            var unmarshaller = GetKeyRotationStatusResponseUnmarshaller.Instance;

            return Invoke<GetKeyRotationStatusRequest,GetKeyRotationStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyRotationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(GetKeyRotationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetKeyRotationStatusRequestMarshaller();
            var unmarshaller = GetKeyRotationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyRotationStatusRequest,GetKeyRotationStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAliases

        /// <summary>
        /// Lists all of the key aliases in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        public ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var marshaller = new ListAliasesRequestMarshaller();
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesRequest,ListAliasesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAliasesRequestMarshaller();
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesRequest,ListAliasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGrants

        /// <summary>
        /// List the grants for a specified key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGrants service method.</param>
        /// 
        /// <returns>The response from the ListGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public ListGrantsResponse ListGrants(ListGrantsRequest request)
        {
            var marshaller = new ListGrantsRequestMarshaller();
            var unmarshaller = ListGrantsResponseUnmarshaller.Instance;

            return Invoke<ListGrantsRequest,ListGrantsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGrantsRequestMarshaller();
            var unmarshaller = ListGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGrantsRequest,ListGrantsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListKeyPolicies

        /// <summary>
        /// Retrieves a list of policies attached to a key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies service method.</param>
        /// 
        /// <returns>The response from the ListKeyPolicies service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public ListKeyPoliciesResponse ListKeyPolicies(ListKeyPoliciesRequest request)
        {
            var marshaller = new ListKeyPoliciesRequestMarshaller();
            var unmarshaller = ListKeyPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListKeyPoliciesRequest,ListKeyPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeyPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListKeyPoliciesResponse> ListKeyPoliciesAsync(ListKeyPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListKeyPoliciesRequestMarshaller();
            var unmarshaller = ListKeyPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeyPoliciesRequest,ListKeyPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListKeys

        /// <summary>
        /// Lists the customer master keys.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        public ListKeysResponse ListKeys(ListKeysRequest request)
        {
            var marshaller = new ListKeysRequestMarshaller();
            var unmarshaller = ListKeysResponseUnmarshaller.Instance;

            return Invoke<ListKeysRequest,ListKeysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListKeysRequestMarshaller();
            var unmarshaller = ListKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeysRequest,ListKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRetirableGrants

        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="retiringPrincipal">The retiring principal for which to list grants. To specify the retiring principal, use the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts (root), IAM users, federated users, and assumed role users. For examples of the ARN syntax for specifying a principal, go to <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>Amazon Web Services General Reference</i>.</param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public ListRetirableGrantsResponse ListRetirableGrants(string retiringPrincipal)
        {
            var request = new ListRetirableGrantsRequest();
            request.RetiringPrincipal = retiringPrincipal;
            return ListRetirableGrants(request);
        }

        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public ListRetirableGrantsResponse ListRetirableGrants()
        {
            var request = new ListRetirableGrantsRequest();
            return ListRetirableGrants(request);
        }

        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetirableGrants service method.</param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public ListRetirableGrantsResponse ListRetirableGrants(ListRetirableGrantsRequest request)
        {
            var marshaller = new ListRetirableGrantsRequestMarshaller();
            var unmarshaller = ListRetirableGrantsResponseUnmarshaller.Instance;

            return Invoke<ListRetirableGrantsRequest,ListRetirableGrantsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRetirableGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRetirableGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(ListRetirableGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListRetirableGrantsRequestMarshaller();
            var unmarshaller = ListRetirableGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRetirableGrantsRequest,ListRetirableGrantsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutKeyPolicy

        /// <summary>
        /// Attaches a policy to the specified key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// <param name="policy">The policy to attach to the key. This is required and delegates back to the account. The key is the root of trust. The policy size limit is 32 KiB (32768 bytes). </param>
        /// <param name="policyName">Name of the policy to be attached. Currently, the only supported name is "default".</param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported.
        /// </exception>
        public PutKeyPolicyResponse PutKeyPolicy(string keyId, string policy, string policyName)
        {
            var request = new PutKeyPolicyRequest();
            request.KeyId = keyId;
            request.Policy = policy;
            request.PolicyName = policyName;
            return PutKeyPolicy(request);
        }

        /// <summary>
        /// Attaches a policy to the specified key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy service method.</param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported.
        /// </exception>
        public PutKeyPolicyResponse PutKeyPolicy(PutKeyPolicyRequest request)
        {
            var marshaller = new PutKeyPolicyRequestMarshaller();
            var unmarshaller = PutKeyPolicyResponseUnmarshaller.Instance;

            return Invoke<PutKeyPolicyRequest,PutKeyPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutKeyPolicyResponse> PutKeyPolicyAsync(PutKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutKeyPolicyRequestMarshaller();
            var unmarshaller = PutKeyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutKeyPolicyRequest,PutKeyPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReEncrypt

        /// <summary>
        /// Encrypts data on the server side with a new customer master key without exposing the
        /// plaintext of the data on the client side. The data is first decrypted and then encrypted.
        /// This operation can also be used to change the encryption context of a ciphertext.
        /// 
        /// 
        ///  
        /// <para>
        /// Unlike other actions, <code>ReEncrypt</code> is authorized twice - once as <code>ReEncryptFrom</code>
        /// on the source key and once as <code>ReEncryptTo</code> on the destination key. We
        /// therefore recommend that you include the <code>"action":"kms:ReEncrypt*"</code> statement
        /// in your key policies to permit re-encryption from or to the key. The statement is
        /// included automatically when you authorize use of the key through the console but must
        /// be included manually when you set a policy by using the <a>PutKeyPolicy</a> function.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt service method.</param>
        /// 
        /// <returns>The response from the ReEncrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// The request was rejected because the specified ciphertext has been corrupted or is
        /// otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because a grant token provided as part of the request is
        /// invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified KeySpec parameter is not valid. The
        /// currently supported value is ENCRYPT/DECRYPT.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the key was not available. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public ReEncryptResponse ReEncrypt(ReEncryptRequest request)
        {
            var marshaller = new ReEncryptRequestMarshaller();
            var unmarshaller = ReEncryptResponseUnmarshaller.Instance;

            return Invoke<ReEncryptRequest,ReEncryptResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReEncrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ReEncryptResponse> ReEncryptAsync(ReEncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReEncryptRequestMarshaller();
            var unmarshaller = ReEncryptResponseUnmarshaller.Instance;

            return InvokeAsync<ReEncryptRequest,ReEncryptResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RetireGrant

        /// <summary>
        /// Retires a grant. You can retire a grant when you're done using it to clean up. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API: <ul> <li>The account that created the
        /// grant</li> <li>The <code>RetiringPrincipal</code>, if present</li> <li>The <code>GranteePrincipal</code>,
        /// if <code>RetireGrant</code> is a grantee operation</li> </ul> The grant to retire
        /// must be identified by its grant token or by a combination of the key ARN and the grant
        /// ID. A grant token is a unique variable-length base64-encoded string. A grant ID is
        /// a 64 character unique identifier of a grant. Both are returned by the <code>CreateGrant</code>
        /// function.
        /// </summary>
        /// <param name="grantToken">Token that identifies the grant to be retired.</param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because a grant token provided as part of the request is
        /// invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public RetireGrantResponse RetireGrant(string grantToken)
        {
            var request = new RetireGrantRequest();
            request.GrantToken = grantToken;
            return RetireGrant(request);
        }

        /// <summary>
        /// Retires a grant. You can retire a grant when you're done using it to clean up. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API: <ul> <li>The account that created the
        /// grant</li> <li>The <code>RetiringPrincipal</code>, if present</li> <li>The <code>GranteePrincipal</code>,
        /// if <code>RetireGrant</code> is a grantee operation</li> </ul> The grant to retire
        /// must be identified by its grant token or by a combination of the key ARN and the grant
        /// ID. A grant token is a unique variable-length base64-encoded string. A grant ID is
        /// a 64 character unique identifier of a grant. Both are returned by the <code>CreateGrant</code>
        /// function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant service method.</param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because a grant token provided as part of the request is
        /// invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public RetireGrantResponse RetireGrant(RetireGrantRequest request)
        {
            var marshaller = new RetireGrantRequestMarshaller();
            var unmarshaller = RetireGrantResponseUnmarshaller.Instance;

            return Invoke<RetireGrantRequest,RetireGrantResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetireGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RetireGrantResponse> RetireGrantAsync(RetireGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RetireGrantRequestMarshaller();
            var unmarshaller = RetireGrantResponseUnmarshaller.Instance;

            return InvokeAsync<RetireGrantRequest,RetireGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeGrant

        /// <summary>
        /// Revokes a grant. You can revoke a grant to actively deny operations that depend on
        /// it.
        /// </summary>
        /// <param name="grantId">Identifier of the grant to be revoked.</param>
        /// <param name="keyId">A unique identifier for the customer master key associated with the grant. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public RevokeGrantResponse RevokeGrant(string grantId, string keyId)
        {
            var request = new RevokeGrantRequest();
            request.GrantId = grantId;
            request.KeyId = keyId;
            return RevokeGrant(request);
        }

        /// <summary>
        /// Revokes a grant. You can revoke a grant to actively deny operations that depend on
        /// it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant service method.</param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public RevokeGrantResponse RevokeGrant(RevokeGrantRequest request)
        {
            var marshaller = new RevokeGrantRequestMarshaller();
            var unmarshaller = RevokeGrantResponseUnmarshaller.Instance;

            return Invoke<RevokeGrantRequest,RevokeGrantResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RevokeGrantResponse> RevokeGrantAsync(RevokeGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeGrantRequestMarshaller();
            var unmarshaller = RevokeGrantResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeGrantRequest,RevokeGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ScheduleKeyDeletion

        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the state
        /// of the CMK changes to <code>PendingDeletion</code>. Before the waiting period ends,
        /// you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After the
        /// waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that point to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is rendered unrecoverable. To restrict
        /// the use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about scheduling a CMK for deletion, go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) to delete. To specify this value, use the unique key ID or the Amazon Resource Name (ARN) of the CMK. Examples: <ul> <li>Unique key ID: 1234abcd-12ab-34cd-56ef-1234567890ab</li> <li>Key ARN: arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</li> </ul>  To obtain the unique key ID and key ARN for a given CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public ScheduleKeyDeletionResponse ScheduleKeyDeletion(string keyId)
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            return ScheduleKeyDeletion(request);
        }

        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the state
        /// of the CMK changes to <code>PendingDeletion</code>. Before the waiting period ends,
        /// you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After the
        /// waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that point to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is rendered unrecoverable. To restrict
        /// the use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about scheduling a CMK for deletion, go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) to delete. To specify this value, use the unique key ID or the Amazon Resource Name (ARN) of the CMK. Examples: <ul> <li>Unique key ID: 1234abcd-12ab-34cd-56ef-1234567890ab</li> <li>Key ARN: arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</li> </ul>  To obtain the unique key ID and key ARN for a given CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="pendingWindowInDays">The waiting period, specified in number of days. After the waiting period ends, AWS KMS deletes the customer master key (CMK). This value is optional. If you include a value, it must be between 7 and 30, inclusive. If you do not include a value, it defaults to 30.</param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public ScheduleKeyDeletionResponse ScheduleKeyDeletion(string keyId, int pendingWindowInDays)
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            request.PendingWindowInDays = pendingWindowInDays;
            return ScheduleKeyDeletion(request);
        }

        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the state
        /// of the CMK changes to <code>PendingDeletion</code>. Before the waiting period ends,
        /// you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After the
        /// waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that point to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is rendered unrecoverable. To restrict
        /// the use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about scheduling a CMK for deletion, go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScheduleKeyDeletion service method.</param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public ScheduleKeyDeletionResponse ScheduleKeyDeletion(ScheduleKeyDeletionRequest request)
        {
            var marshaller = new ScheduleKeyDeletionRequestMarshaller();
            var unmarshaller = ScheduleKeyDeletionResponseUnmarshaller.Instance;

            return Invoke<ScheduleKeyDeletionRequest,ScheduleKeyDeletionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ScheduleKeyDeletion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScheduleKeyDeletion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(ScheduleKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ScheduleKeyDeletionRequestMarshaller();
            var unmarshaller = ScheduleKeyDeletionResponseUnmarshaller.Instance;

            return InvokeAsync<ScheduleKeyDeletionRequest,ScheduleKeyDeletionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAlias

        /// <summary>
        /// Updates an alias to map it to a different key.
        /// 
        ///  
        /// <para>
        /// An alias is not a property of a key. Therefore, an alias can be mapped to and unmapped
        /// from an existing key without changing the properties of the key. 
        /// </para>
        ///  
        /// <para>
        /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). An alias must start with the word "alias" followed by a forward
        /// slash (alias/). An alias that begins with "aws" after the forward slash (alias/aws...)
        /// is reserved by Amazon Web Services (AWS). 
        /// </para>
        ///  
        /// <para>
        /// The alias and the key it is mapped to must be in the same AWS account and the same
        /// region.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the name of the alias to be modified. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/aws" are reserved.</param>
        /// <param name="targetKeyId">Unique identifier of the customer master key to be mapped to the alias. This value can be a globally unique identifier or the fully specified ARN of a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul>  You can call <a>ListAliases</a> to verify that the alias is mapped to the correct <code>TargetKeyId</code>.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public UpdateAliasResponse UpdateAlias(string aliasName, string targetKeyId)
        {
            var request = new UpdateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return UpdateAlias(request);
        }

        /// <summary>
        /// Updates an alias to map it to a different key.
        /// 
        ///  
        /// <para>
        /// An alias is not a property of a key. Therefore, an alias can be mapped to and unmapped
        /// from an existing key without changing the properties of the key. 
        /// </para>
        ///  
        /// <para>
        /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). An alias must start with the word "alias" followed by a forward
        /// slash (alias/). An alias that begins with "aws" after the forward slash (alias/aws...)
        /// is reserved by Amazon Web Services (AWS). 
        /// </para>
        ///  
        /// <para>
        /// The alias and the key it is mapped to must be in the same AWS account and the same
        /// region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var marshaller = new UpdateAliasRequestMarshaller();
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasRequest,UpdateAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAliasRequestMarshaller();
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAliasRequest,UpdateAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateKeyDescription

        /// <summary>
        /// Updates the description of a key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// <param name="description">New description for the key.</param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public UpdateKeyDescriptionResponse UpdateKeyDescription(string keyId, string description)
        {
            var request = new UpdateKeyDescriptionRequest();
            request.KeyId = keyId;
            request.Description = description;
            return UpdateKeyDescription(request);
        }

        /// <summary>
        /// Updates the description of a key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a customer master key
        /// (CMK), go to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        public UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest request)
        {
            var marshaller = new UpdateKeyDescriptionRequestMarshaller();
            var unmarshaller = UpdateKeyDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateKeyDescriptionRequest,UpdateKeyDescriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKeyDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateKeyDescriptionRequestMarshaller();
            var unmarshaller = UpdateKeyDescriptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKeyDescriptionRequest,UpdateKeyDescriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}