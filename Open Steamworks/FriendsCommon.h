//==========================  Open Steamworks  ================================
//
// This file is part of the Open Steamworks project. All individuals associated
// with this project do not claim ownership of the contents
// 
// The code, comments, and all related files, projects, resources,
// redistributables included with this project are Copyright Valve Corporation.
// Additionally, Valve, the Valve logo, Half-Life, the Half-Life logo, the
// Lambda logo, Steam, the Steam logo, Team Fortress, the Team Fortress logo,
// Opposing Force, Day of Defeat, the Day of Defeat logo, Counter-Strike, the
// Counter-Strike logo, Source, the Source logo, and Counter-Strike Condition
// Zero are trademarks and or registered trademarks of Valve Corporation.
// All other trademarks are property of their respective owners.
//
//=============================================================================

#ifndef FRIENDSCOMMON_H
#define FRIENDSCOMMON_H
#ifdef _WIN32
#pragma once
#endif



#define CLIENTFRIENDS_INTERFACE_VERSION "CLIENTFRIENDS_INTERFACE_VERSION001"

#define STEAMFRIENDS_INTERFACE_VERSION_001 "SteamFriends001"
#define STEAMFRIENDS_INTERFACE_VERSION_002 "SteamFriends002"
#define STEAMFRIENDS_INTERFACE_VERSION_003 "SteamFriends003"
#define STEAMFRIENDS_INTERFACE_VERSION_004 "SteamFriends004"
#define STEAMFRIENDS_INTERFACE_VERSION_005 "SteamFriends005"
#define STEAMFRIENDS_INTERFACE_VERSION_006 "SteamFriends006"
#define STEAMFRIENDS_INTERFACE_VERSION_007 "SteamFriends007"
#define STEAMFRIENDS_INTERFACE_VERSION_008 "SteamFriends008"
#define STEAMFRIENDS_INTERFACE_VERSION_009 "SteamFriends009"
#define STEAMFRIENDS_INTERFACE_VERSION_010 "SteamFriends010"
#define STEAMFRIENDS_INTERFACE_VERSION_011 "SteamFriends011"

//-----------------------------------------------------------------------------
// Purpose: avatar sizes, used in ISteamFriends::GetFriendAvatar()
//-----------------------------------------------------------------------------
enum EAvatarSize
{
	k_EAvatarSize32x32 = 0,
	k_EAvatarSize64x64 = 1,
};

enum ECallState
{
	k_ECallStateUnknown = 0,
	k_ECallStateWaiting = 1,
	k_ECallStateDialing = 2,
	k_ECallStateRinging = 3,
	k_ECallStateInCall = 4,
};

//-----------------------------------------------------------------------------
// Purpose: Chat Entry Types (previously was only friend-to-friend message types)
//-----------------------------------------------------------------------------
enum EChatEntryType
{
	k_EChatEntryTypeInvalid = 0, 
	k_EChatEntryTypeChatMsg = 1,		// Normal text message from another user
	k_EChatEntryTypeTyping = 2,			// Another user is typing (not used in multi-user chat)
	k_EChatEntryTypeInviteGame = 3,		// Invite from other user into that users current game
	k_EChatEntryTypeEmote = 4,			// text emote message
	k_EChatEntryTypeLobbyGameStart = 5,	// lobby game is starting
	k_EChatEntryTypeLeftConversation = 6, // user has left the conversation ( closed chat window )
	// Above are previous FriendMsgType entries, now merged into more generic chat entry types
};

//-----------------------------------------------------------------------------
// Purpose: set of relationships to other users
//-----------------------------------------------------------------------------
enum EFriendRelationship
{
	k_EFriendRelationshipNone = 0,
	k_EFriendRelationshipBlocked = 1,
	k_EFriendRelationshipRequestRecipient = 2,
	k_EFriendRelationshipFriend = 3,
	k_EFriendRelationshipRequestInitiator = 4,
	k_EFriendRelationshipIgnored = 5,
	k_EFriendRelationshipIgnoredFriend = 6,
	k_EFriendRelationshipSuggested = 7,
};

enum EChatRoomType
{
	k_EChatRoomTypeFriend = 1,
	k_EChatRoomTypeMUC = 2,
	k_EChatRoomTypeLobby = 3,
};

enum EChatRoomVoiceStatus
{
	eChatRoomVoiceStatusBad = 0,
	eChatRoomVoiceStatusUnknownRoom = 1,
	eChatRoomVoiceStatusUnknownUser = 2,
	eChatRoomVoiceStatusNotSpeaking = 3,
	eChatRoomVoiceStatusConnectedSpeaking = 4,
	eChatRoomVoiceStatusConnectedSpeakingData = 5,
	eChatRoomVoiceStatusNotConnectedSpeaking = 6,
	eChatRoomVoiceStatusConnecting = 7,
	eChatRoomVoiceStatusUnreachable = 8,
	eChatRoomVoiceStatusDisconnected = 9,
	eChatRoomVoiceStatusCount = 10,
};

enum EClanRank
{
	k_EClanRankNone = 0,
	k_EClanRankOwner = 1,
	k_EClanRankOfficer = 2,
	k_EClanRankMember = 3,
};

enum EClanRelationship
{
	eClanRelationshipNone = 0,
	eClanRelationshipBlocked = 1,
	eClanRelationshipInvited = 2,
	eClanRelationshipMember = 3,
	eClanRelationshipKicked = 4,
};

// for enumerating friends list
enum EFriendFlags
{
	k_EFriendFlagNone			= 0x00,
	k_EFriendFlagBlocked		= 0x01,
	k_EFriendFlagFriendshipRequested	= 0x02,
	k_EFriendFlagImmediate		= 0x04,			// "regular" friend
	k_EFriendFlagClanMember		= 0x08,
	k_EFriendFlagOnGameServer	= 0x10,	
	//	k_EFriendFlagHasPlayedWith	= 0x20,	// not currently used
	//	k_EFriendFlagFriendOfFriend	= 0x40,	// not currently used
	k_EFriendFlagRequestingFriendship = 0x80,
	k_EFriendFlagRequestingInfo = 0x100,
	k_EFriendFlagIgnored		= 0x200,
	k_EFriendFlagIgnoredFriend	= 0x400,
	k_EFriendFlagSuggested		= 0x800,
	k_EFriendFlagAll			= 0xFFFF,
};

// for backwards compat
typedef EFriendFlags k_EFriendFlags;


//-----------------------------------------------------------------------------
// Purpose: list of states a friend can be in
//-----------------------------------------------------------------------------
enum EPersonaState
{
	k_EPersonaStateOffline = 0,			// friend is not currently logged on
	k_EPersonaStateOnline = 1,			// friend is logged on
	k_EPersonaStateBusy = 2,			// user is on, but busy
	k_EPersonaStateAway = 3,			// auto-away feature
	k_EPersonaStateSnooze = 4,			// auto-away for a long time
	k_EPersonaStateLookingToTrade = 5,	// Looking to Trade
	k_EPersonaStateLookingToPlay = 6,	// Looking to Play
	k_EPersonaStateMax,
};

// used in PersonaStateChange_t::m_nChangeFlags to describe what's changed about a user
// these flags describe what the client has learned has changed recently, so on startup you'll see a name, avatar & relationship change for every friend
enum EPersonaChange
{
	k_EPersonaChangeName		= 0x001,
	k_EPersonaChangeStatus		= 0x002,
	k_EPersonaChangeComeOnline	= 0x004,
	k_EPersonaChangeGoneOffline	= 0x008,
	k_EPersonaChangeGamePlayed	= 0x010,
	k_EPersonaChangeGameServer	= 0x020,
	k_EPersonaChangeAvatar		= 0x040,
	k_EPersonaChangeJoinedSource= 0x080,
	k_EPersonaChangeLeftSource	= 0x100,
	k_EPersonaChangeRelationshipChanged = 0x200,
	k_EPersonaChangeNameFirstSet = 0x400,
	k_EPersonaChangeFacebookInfo = 0x800,
};

enum EChatPermission
{
	k_EChatPermissionClose = 1,
	k_EChatPermissionInvite = 2,
	k_EChatPermissionTalk = 8,
	k_EChatPermissionKick = 16,
	k_EChatPermissionMute = 32,
	k_EChatPermissionSetMetadata = 64,
	k_EChatPermissionChangePermissions = 128,
	k_EChatPermissionBan = 256,
	k_EChatPermissionChangeAccess = 512,
	k_EChatPermissionEveryoneNotInClanDefault = 8,
	k_EChatPermissionEveryoneDefault = 10,
	k_EChatPermissionMemberDefault = 282,
	k_EChatPermissionOfficerDefault = 282,
	k_EChatPermissionOwnerDefault = 891,
	k_EChatPermissionMask = 1019,
};

//-----------------------------------------------------------------------------
// Purpose: Chat Room Enter Responses
//-----------------------------------------------------------------------------
enum EChatRoomEnterResponse
{
	k_EChatRoomEnterResponseSuccess = 1,		// Success
	k_EChatRoomEnterResponseDoesntExist = 2,	// Chat doesn't exist (probably closed)
	k_EChatRoomEnterResponseNotAllowed = 3,		// General Denied - You don't have the permissions needed to join the chat
	k_EChatRoomEnterResponseFull = 4,			// Chat room has reached its maximum size
	k_EChatRoomEnterResponseError = 5,			// Unexpected Error
	k_EChatRoomEnterResponseBanned = 6,			// You are banned from this chat room and may not join
};

enum EChatAction
{
	k_EChatActionInviteChat = 1,
	k_EChatActionKick = 2,
	k_EChatActionBan = 3,
	k_EChatActionUnBan = 4,
	k_EChatActionStartVoiceSpeak = 5,
	k_EChatActionEndVoiceSpeak = 6,
	k_EChatActionLockChat = 7,
	k_EChatActionUnlockChat = 8,
	k_EChatActionCloseChat = 9,
	k_EChatActionSetJoinable = 10,
	k_EChatActionSetUnjoinable = 11,
	k_EChatActionSetOwner = 12,
	k_EChatActionSetInvisibleToFriends = 13,
	k_EChatActionSetVisibleToFriends = 14,
	k_EChatActionSetModerated = 15,
	k_EChatActionSetUnmoderated = 16,
};

enum EChatActionResult
{
	k_EChatActionResultSuccess = 1,
	k_EChatActionResultError = 2,
	k_EChatActionResultNotPermitted = 3,
	k_EChatActionResultNotAllowedOnClanMember = 4,
	k_EChatActionResultNotAllowedOnBannedUser = 5,
	k_EChatActionResultNotAllowedOnChatOwner = 6,
	k_EChatActionResultNotAllowedOnSelf = 7,
	k_EChatActionResultChatDoesntExist = 8,
	k_EChatActionResultChatFull = 9,
	k_EChatActionResultVoiceSlotsFull = 10,
};

//-----------------------------------------------------------------------------
// Purpose: user restriction flags
//-----------------------------------------------------------------------------
enum EUserRestriction
{
	k_nUserRestrictionNone		= 0,	// no known chat/content restriction
	k_nUserRestrictionUnknown	= 1,	// we don't know yet (user offline)
	k_nUserRestrictionAnyChat	= 2,	// user is not allowed to (or can't) send/recv any chat
	k_nUserRestrictionVoiceChat	= 4,	// user is not allowed to (or can't) send/recv voice chat
	k_nUserRestrictionGroupChat	= 8,	// user is not allowed to (or can't) send/recv group chat
	k_nUserRestrictionRating	= 16,	// user is too young according to rating in current region
};


// size limits on Rich Presence data
enum { k_cchMaxRichPresenceKeys = 20 };
enum { k_cchMaxRichPresenceKeyLength = 64 };
enum { k_cchMaxRichPresenceValueLength = 256 };


// maximum length of friend group name (not including terminating nul!)
const int k_cchMaxFriendGroupName = 64;

// maximum number of groups a single user is allowed
const int k_cFriendGroupLimit = 100;



#pragma pack( push, 8 )




// k_iSteamFriendsCallbacks callbacks




//-----------------------------------------------------------------------------
// Purpose: called when a friends' status changes
//-----------------------------------------------------------------------------
struct PersonaStateChange_t
{
	enum { k_iCallback = k_iSteamFriendsCallbacks + 4 };
	
	CSteamID m_ulSteamID;		// steamID of the friend who changed
	EPersonaChange m_nChangeFlags;		// what's changed
};


//-----------------------------------------------------------------------------
// Purpose: posted when game overlay activates or deactivates
//			the game can use this to be pause or resume single player games
//-----------------------------------------------------------------------------
struct GameOverlayActivated_t
{
	enum { k_iCallback = k_iSteamFriendsCallbacks + 31 };

	uint8 m_bActive;	// true if it's just been activated, false otherwise
};


//-----------------------------------------------------------------------------
// Purpose: called when the user tries to join a different game server from their friends list
//			game client should attempt to connect to specified server when this is received
//-----------------------------------------------------------------------------
struct GameServerChangeRequested_t
{
	enum { k_iCallback = k_iSteamFriendsCallbacks + 32 };

	char m_rgchServer[64];		// server address ("127.0.0.1:27015", "tf2.valvesoftware.com")
	char m_rgchPassword[64];	// server password, if any
};


//-----------------------------------------------------------------------------
// Purpose: called when the user tries to join a lobby from their friends list
//			game client should attempt to connect to specified lobby when this is received
//-----------------------------------------------------------------------------
struct GameLobbyJoinRequested_t
{
	enum { k_iCallback = k_iSteamFriendsCallbacks + 33 };

	CSteamID m_steamIDLobby;
	CSteamID m_steamIDFriend;		// the friend they did the join via (will be invalid if not directly via a friend)
};


//-----------------------------------------------------------------------------
// Purpose: called when an avatar is loaded in from a previous GetLargeFriendAvatar() call
//			if the image wasn't already available
//-----------------------------------------------------------------------------
struct AvatarImageLoaded_t
{
	enum { k_iCallback = k_iSteamFriendsCallbacks + 34 };

	CSteamID m_steamID; // steamid the avatar has been loaded for
	int m_iImage; // the image index of the now loaded image
	int m_iWide; // width of the loaded image
	int m_iTall; // height of the loaded image
};


//-----------------------------------------------------------------------------
// Purpose: marks the return of a request officer list call
//-----------------------------------------------------------------------------
struct ClanOfficerListResponse_t
{
	enum { k_iCallback = k_iSteamFriendsCallbacks + 35 };

	CSteamID m_steamIDClan;
	int m_cOfficers;
	uint8 m_bSuccess;
};

//-----------------------------------------------------------------------------
// Purpose: callback indicating updated data about friends rich presence information
//-----------------------------------------------------------------------------
struct FriendRichPresenceUpdate_t
{
	enum { k_iCallback = k_iSteamFriendsCallbacks + 36 };

	CSteamID m_steamIDFriend;	// friend who's rich presence has changed
	AppId_t m_nAppID;			// the appID of the game (should always be the current game)
};

//-----------------------------------------------------------------------------
// Purpose: called when the user tries to join a game from their friends list
//			rich presence will have been set with the "connect" key which is set here
//-----------------------------------------------------------------------------
struct GameRichPresenceJoinRequested_t
{
	enum { k_iCallback = k_iSteamFriendsCallbacks + 37 };

	CSteamID m_steamIDFriend;		// the friend they did the join via (will be invalid if not directly via a friend)
	char m_rgchConnect[k_cchMaxRichPresenceValueLength];
};



// k_iClientFriendsCallbacks callbacks



//-----------------------------------------------------------------------------
// Purpose: called after a friend has been successfully added
//-----------------------------------------------------------------------------
struct FriendAdded_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 3 };

	EResult m_eResult;
	uint64 m_ulSteamID;	// steamID of the friend who was just added
};


//-----------------------------------------------------------------------------
// Purpose: called when a user is requesting friendship
//			the persona details of this user are guaranteed to be available locally
//			at the point this callback occurs
//-----------------------------------------------------------------------------
struct UserRequestingFriendship_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 4 };

	CSteamID m_ulSteamID;		// steamID of the friend who just added us
};


//-----------------------------------------------------------------------------
// Purpose: called when this client has received a chat/invite/etc. message from a friend
//-----------------------------------------------------------------------------
struct FriendChatMsg_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 5 };
	
	CSteamID m_ulReceiver;			// other participant in the msg
	CSteamID m_ulSender;			// steamID of the friend who has sent this message
	uint16 m_eChatEntryType;
	uint8 m_bLimitedAccount;
	uint32 m_iChatID;				// chat id
};

struct FriendInvited_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 6 };

	EResult m_eResult;
};

struct ChatRoomInvite_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 7 };

	CSteamID m_ulSteamIDChat;
	CSteamID m_ulSteamIDPatron;
	CSteamID m_ulSteamIDFriendChat;

	EChatRoomType m_EChatRoomType;

	char m_rgchChatRoomName[ 128 ];
};

struct ChatRoomEnter_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 8 };

	CSteamID m_ulSteamIDChat;

	EChatRoomType m_EChatRoomType;

	uint64 m_ulSteamIDOwner; // Cannot use CSteamID here due to padding issues.
	CSteamID m_ulSteamIDClan;
	CSteamID m_ulSteamIDFriendChat;

	bool m_bLocked;
	uint32 m_rgfChatPermissions;
	EChatRoomEnterResponse m_EChatRoomEnterResponse;

	char m_rgchChatRoomName[ 128 ];
};

struct ChatMemberStateChange_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 9 };

	CSteamID m_ulSteamIDChat;
	CSteamID m_ulSteamIDUserChanged;
	EChatMemberStateChange m_rgfChatMemberStateChange;
	uint64 m_ulSteamIDMakingChange; // Cannot use CSteamID here due to padding issues.
};

struct ChatRoomMsg_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 10 };

	CSteamID m_ulSteamIDChat;
	CSteamID m_ulSteamIDUser;
	uint8 m_eChatEntryType;
	uint32 m_iChatID;
};

struct ChatRoomDlgClose_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 11 };

	CSteamID m_SteamID;
};

struct ChatRoomClosing_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 12 };

	CSteamID m_ulSteamIDChat;
};

struct ChatRoomKicking_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 13 };

	CSteamID m_ulSteamIDChat;
	CSteamID m_ulSteamIDAdmin;
};

struct ChatRoomBanning_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 14 };

	CSteamID m_ulSteamIDChat;
	CSteamID m_ulSteamIDAdmin;
};

struct ChatRoomCreate_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 15 };

	EResult m_eResult;

	uint64 m_ulSteamIDChat; // Cannot use CSteamID here due to padding issues.
	CSteamID m_ulSteamIDFriendChat;
};

struct OpenChatDialog_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 16 };

	CSteamID m_ulSteamID;
};

struct ChatRoomActionResult_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 17 };

	CSteamID m_ulSteamIDChat;
	CSteamID m_ulSteamIDUserActedOn;
	EChatAction m_EChatAction;
	EChatActionResult m_EChatActionResult;
};

struct ChatRoomDlgSerialized_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 18 };

	CSteamID m_ulSteamID;
};

struct ClanInfoChanged_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 19 };

	CSteamID m_GroupID;

	bool m_bNameChanged;
	bool m_bAvatarChanged;
	bool m_bAccountInfoChanged;
};

struct ChatMemberInfoChanged_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 20 };

	CSteamID m_ulSteamIDChat;
	CSteamID m_ulSteamIDUser;
	uint32  m_rgfChatMemberPermissions;
};

struct ChatRoomInfoChanged_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 21 };

	CSteamID m_ulSteamIDChat;
	uint32 m_rgfChatRoomDetails;
	uint64 m_ulSteamIDMakingChange; // Cannot use CSteamID here due to padding issues.
};

struct ChatRoomSpeakChanged_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 23 };

	CSteamID m_ulSteamIDChat;
	CSteamID m_ulSteamIDUser;
	bool m_bSpeaking;
};

struct NotifyIncomingCall_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 24 };

	HVoiceCall m_Handle;

	uint64 m_ulSteamID; // Cannot use CSteamID here due to padding issues.
	CSteamID m_ulSteamIDChat;

	bool m_bIncoming;
};

struct NotifyHangup_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 25 };

	HVoiceCall m_Handle;
};

struct NotifyRequestResume_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 26 };

	HVoiceCall m_Handle;
};

struct NotifyChatRoomVoiceStateChanged_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 27 };

	CSteamID m_steamChatRoom;
	CSteamID m_steamUser;
};

struct ChatRoomDlgUIChange_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 28 };

	CSteamID m_SteamIDChat;
	bool m_bShowAvatars;
	bool m_bBeepOnNewMsg;
	bool m_bShowSteamIDs;
	bool m_bShowTimestampOnNewMsg;
};

struct FriendIgnored_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 30 };

	EResult m_eResult;
	uint64 m_ulSteamID; // Cannot use CSteamID here due to padding issues.
	CSteamID m_ulSteamIDFriend;
	bool m_bIgnored;
};

struct FriendProfileInfoReceived_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 34 };

	CSteamID m_ulSteamID;
};

struct FriendsMenuChange_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 36 };

	bool m_bShowAvatars;
	bool m_bSortByName;
	bool m_bShowOnlineOnly;
	bool m_bShowUntaggedFriends;
};

//-----------------------------------------------------------------------------
// Purpose: called when the user requests the history of player names on a given account
//-----------------------------------------------------------------------------
struct NameHistoryResponse_t
{
	enum { k_iCallback = k_iClientFriendsCallbacks + 47 };
	int m_cSuccessfulLookups;		// number of lookups that were successful
	int m_cFailedLookups;			// number of lookups that failed for one reason or another
};

#pragma pack( pop )



#endif // FRIENDSCOMMON_H
